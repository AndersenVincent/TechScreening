using TSGUI.Shared.DataTypes;
using TSGUI.Shared;

namespace TSGUI.Server.Models.AgeGroups
{
    public class FromThirtyFiveToFourtyFour : EmployeeAgeGroup
    {
        public FromThirtyFiveToFourtyFour(Employee employee) : base(employee)
        {
            Gender = employee.Gender;
            SicknessType = employee.SicknessType;
        }

        public override int Prediction => this switch
        {
            (Gender.Female, SicknessType.Physical) => 2,
            (Gender.Female, SicknessType.Mental) => 8,
            
            (Gender.Male, SicknessType.Physical) => 3,
            (Gender.Male, SicknessType.Mental) => 8,
            
            (Gender.Other, SicknessType.Physical) => 3,
            (Gender.Other, SicknessType.Mental) => 5,
            
            _ => throw new NotImplementedException()
        };
    }
}
