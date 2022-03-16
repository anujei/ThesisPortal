using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhDThesisPortal.Models
{
    [Table("SubmissionDetails")]
    public class SubmissionDetail
    {
        [Display(Name = "Student Id")]
        [ForeignKey(nameof(SubmissionDetail.User))]      // foreign key to the object in the current model.
        public Guid Id { get; set; }           // User Id of the Project
        public MyIdentityUser User { get; set; }

        [Display(Name = "Submission ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmissionId { get; set; }

        [Display(Name ="Submission Description")]
        public string Description { get; set; }
        public string SubmissionFilePath { get; set; }

        #region Navigation Properties to the Department Model 

        [Display(Name = "Department Name")]
        [Required]
        [ForeignKey(nameof(Subject.Department))]      // foreign key to the object in the current model.
        public int DepartmentId { get; set; }           // department Id of the Subject

        public Department Department { get; set; }

        #endregion

        #region Navigation Properties to the Project Model
        public ICollection<Project> Projects { get; set; }
        #endregion
    }
}
