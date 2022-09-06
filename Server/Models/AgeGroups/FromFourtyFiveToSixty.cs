using TSGUI.Shared.DataTypes;
using TSGUI.Shared;

namespace TSGUI.Server.Models.AgeGroups
{
    public class FromFourtyFiveToSixty : EmployeeAgeGroup
    {
        public FromFourtyFiveToSixty(Employee employee) : base(employee)
        {
            Gender = employee.Gender;
            SicknessType = employee.SicknessType;
        }

        public override int Prediction => this switch
        {
            (Gender.Female, SicknessType.Physical) => 3,
            (Gender.Female, SicknessType.Mental) => 10,
            
            (Gender.Male, SicknessType.Physical) => 3,
            (Gender.Male, SicknessType.Mental) => 10,
            
            (Gender.Other, SicknessType.Physical) => 3,
            (Gender.Other, SicknessType.Mental) => 6,
            _ => throw new NotImplementedException()
        };
    }
}
