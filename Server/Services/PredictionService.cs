using Microsoft.AspNetCore.Mvc;
using TSGUI.Shared.DataTypes;
using TSGUI.Shared;
using TSGUI.Server.Models;
using TSGUI.Server.Models.AgeGroups;

namespace TSGUI.Server.Services
{
    public interface IPredictionService
    {
        ActionResult<int?> Predict(Employee employee);
    }
    public class PredictionService : IPredictionService
    {
        public ActionResult<int?> Predict(Employee employee)
        {
            EmployeeAgeGroup ageGroup = GetAgeGroup(employee);

            return GenerateLetterType(ageGroup.Prediction);
        }

        private EmployeeAgeGroup GetAgeGroup(Employee employee)
        {
            if (employee.Age < 14)
                return null;

            if (employee.Age < 25)
                return new UnderTwentyFive(employee);
            if (employee.Age >= 25 && employee.Age <= 34)
                return new FromTwentyFiveToThirtyFour(employee);
            if (employee.Age >= 35 && employee.Age <= 44)
                return new FromThirtyFiveToFourtyFour(employee);
            if (employee.Age >= 45 && employee.Age <= 60)
                return new FromFourtyFiveToSixty(employee);
            if (employee.Age > 60)
                return new AboveSixty(employee);

            return null;
        }

        private ActionResult GenerateLetterType(int prediction)
        {
            string msg;

            if (prediction <= 2)
                msg = "Letter with a link to a questionnaire";
            else if (prediction > 2 && prediction <= 4)
                msg = "Letter with a telephone appointment";
            else if (prediction > 4)
                msg = "Letter with an invitation for a physical visit";
            else
                return new BadRequestObjectResult("");

            return new OkObjectResult(msg);
        }
    }
}
