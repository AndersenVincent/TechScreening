using TSGUI.Shared.DataTypes;
using TSGUI.Shared;

namespace TSGUI.Server.Models.AgeGroups
{
    public class FromTwentyFiveToThirtyFour : EmployeeAgeGroup
    {
        public FromTwentyFiveToThirtyFour(Employee employee) : base(employee)
        {
            Gender = employee.Gender;
            SicknessType = employee.SicknessType;
        }

        public override int Prediction => this switch
        {
            (Gender.Female, SicknessType.Physical) => 2,
            (Gender.Female, SicknessType.Mental) => 6,
            
            (Gender.Male, SicknessType.Physical) => 2,
            (Gender.Male, SicknessType.Mental) => 7,
            
            (Gender.Other, SicknessType.Physical) => 2,
            (Gender.Other, SicknessType.Mental) => 4,
            _ => throw new NotImplementedException()
        };
    }
}
