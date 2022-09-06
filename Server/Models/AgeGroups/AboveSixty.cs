using TSGUI.Shared.DataTypes;
using TSGUI.Shared;
namespace TSGUI.Server.Models.AgeGroups
{
    public class AboveSixty : EmployeeAgeGroup
    {
        public AboveSixty(Employee employee) : base(employee)
        {
            Gender = employee.Gender;
            SicknessType = employee.SicknessType;
        }

        public override int Prediction => this switch
        {
            (Gender.Female, SicknessType.Physical) => 3,
            (Gender.Female, SicknessType.Mental) => 12,
            
            (Gender.Male, SicknessType.Physical) => 5,
            (Gender.Male, SicknessType.Mental) => 11,
            
            (Gender.Other, SicknessType.Physical) => 4,
            (Gender.Other, SicknessType.Mental) => 12,
            _ => throw new NotImplementedException()
        };
    }
}
