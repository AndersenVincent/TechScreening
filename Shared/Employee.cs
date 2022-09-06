using System.ComponentModel.DataAnnotations;

using TSGUI.Shared.DataTypes;

namespace TSGUI.Shared
{
    [Serializable]
    public class Employee
    {
        public Guid Id { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public SicknessType SicknessType { get; set; }
        
        [Range(14, int.MaxValue, ErrorMessage = "Employee must at least be 14 years old.")]
        public int Age { get; set; }

        [Required] //Validate at frontend level
        public Adress Adress{ get; set; }

    }
}
