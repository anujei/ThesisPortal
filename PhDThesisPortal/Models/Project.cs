using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhDThesisPortal.Models
{
    public class Project
    {
        [Display(Name = "Project Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(10, ErrorMessage = "{0} cannot be more than {1} character")]
        [MinLength(8, ErrorMessage = "{0} should have at least {1} characters")]
        public int ProjectId { get; set; }

        [Display(Name = "SubmissionDetails")]
        [Required]
        [ForeignKey(nameof(Project.SubmissionDetails))]      // foreign key to the object in the current model.
        public int SubmissionId { get; set; }           // Subject Id of the Project
        public SubmissionDetail SubmissionDetails { get; set; }
        public string Description { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        public DateTime EndDate { get; set; }

        #region Navigation Properties to the Subject Model 

        [Display(Name = "Subject Name")]
        [ForeignKey(nameof(Project.Subject))]      // foreign key to the object in the current model.
        public int SubjectId { get; set; }           // Subject Id of the Project
        public Subject Subject { get; set; }

        #endregion

        #region Navigation Properties to the Faculty Model 

        [Display(Name = "Faculty Id")]
        [Required]
        [ForeignKey(nameof(Project.Faculty))]      // foreign key to the object in the current model.
        public int FacultyId { get; set; }           // User Id of the Project
        public Faculty Faculty { get; set; }

        #endregion

        [Display(Name = "Completion of Project")]
        public int CompletionPercentage { get; set; }
    }
}
