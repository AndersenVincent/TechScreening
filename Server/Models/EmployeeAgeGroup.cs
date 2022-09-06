using TSGUI.Shared;
using TSGUI.Shared.DataTypes;

namespace TSGUI.Server.Models
{
    public abstract class EmployeeAgeGroup
    {
        public Gender Gender{ get; set; }
        public SicknessType SicknessType{ get; set; }

        public EmployeeAgeGroup(Employee employee )
        {
            Gender = employee.Gender;
            SicknessType = employee.SicknessType;
        }
        public void Deconstruct(out Gender gender, out SicknessType sicknessType)
        {
            gender = Gender;
            sicknessType = SicknessType;
        }

        public abstract int Prediction{ get;}

    }
}
