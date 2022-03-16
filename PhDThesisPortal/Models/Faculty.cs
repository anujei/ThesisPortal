using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace PhDThesisPortal.Models
{
    [Table("Faculties")]
    public class Faculty
    {
        [Display(Name = "Faculty Id")]
        [Key]
        public int FacultyId { get; set; } 

        [Display(Name ="Faculty Type")]
        [Required]
        [StringLength(20, ErrorMessage = "{0} cannot have more than {1} character")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} character")]
        public string FacultyType { get; set; }

        [Display(Name = "Faculty Name")]
        [Required]
        [StringLength(20, ErrorMessage = "{0} cannot have more than {1} character")]
        [MinLength(3, ErrorMessage = "{0} should have at least {1} character")]
        public string FacultyName { get; set; }

        #region Navigation Properties to the Department Model 

        [Display(Name = "Department Name")]
        [Required]
        [ForeignKey(nameof(Faculty.Department))]      // foreign key to the object in the current model.
        public int DepartmentId { get; set; }           // department Id of the Subject

        public Department Department { get; set; }

        #endregion

        #region Navigation Properties to the Project Model
        public ICollection<Project> Projects { get; set; }
        #endregion

    }
}
