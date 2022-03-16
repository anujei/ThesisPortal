using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhDThesisPortal.Models
{
    [Table("Subjects")]
    public class Subject
    {
        
        [Display(Name = "Subject ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }

        [Display(Name = "Name of the Subject")]
        [Required]
        [StringLength(50)]
        [MinLength(3)]
        public string SubjectName { get; set; }

        #region Navigation Properties to the Department Model 

        [Display(Name = "Department Name")]
        [Required]
        [ForeignKey(nameof(Subject.Department))]      // foreign key to the object in the current model.
        public int DepartmentId { get; set; }           // department Id of the Subject

        public Department Department { get; set; }

        #endregion
        
        #region Navigation Properties to the Faculty Model
        public ICollection<Faculty> Faculties { get; set; }
        #endregion

        #region Navigation Properties to the Project Model
        public ICollection<Project> Projects { get; set; }
        #endregion
    }
}
