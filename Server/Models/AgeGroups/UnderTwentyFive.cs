using TSGUI.Shared.DataTypes;
using TSGUI.Shared;

namespace TSGUI.Server.Models.AgeGroups
{
    public class UnderTwentyFive : EmployeeAgeGroup
    {
        public UnderTwentyFive(Employee employee) : base(employee)
        {
            Gender = employee.Gender;
            SicknessType = employee.SicknessType;
        }

        public override int Prediction => this switch
        {
            (Gender.Female, SicknessType.Physical) => 1,
            (Gender.Female, SicknessType.Mental) => 4,
            
            (Gender.Male, SicknessType.Physical) => 2,
            (Gender.Male, SicknessType.Mental) => 5,
            
            (Gender.Other, SicknessType.Physical) => 1,
            (Gender.Other, SicknessType.Mental) => 3,
            _ => throw new NotImplementedException()
        };
    }
}
