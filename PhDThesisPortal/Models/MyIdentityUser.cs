using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhDThesisPortal.Models
{
    public class MyIdentityUser
        : IdentityUser<Guid>
    {

        [Display(Name = "Display Name")]
        [Required]
        [MinLength(3)]
        [StringLength(60)]
        public string DisplayName { get; set; }

        [Display(Name = "Gender")]
        [PersonalData]                                  // for GDPR Compliance.
        [Required]
        public string Gender { get; set; }

        [Display(Name = "User Role")]
        [Required]
        public int Role { get; set; }

        [Display(Name = "Student Enrollment Number")]
        [Required]
        [StringLength(8, ErrorMessage = "{0} cannot have more than {1} character")]
        [MinLength(8, ErrorMessage = "{0} should have at least {1} character")]
        public string StudentEnrollmentId { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        #region Navigation Properties to the Project Model
        public ICollection<Project> Projects { get; set; }
        #endregion
    }
}
