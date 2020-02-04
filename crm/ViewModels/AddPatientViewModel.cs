using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crm.ViewModels
{
    public class AddPatientViewModel
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }
        [Required]
        [Display(Name = "Blood type")]
        public string BloodType { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public int BMI { get; set; }
        [Required]
        public int BFPercentage { get; set; }

        public AddPatientViewModel()
        {

        }

    }
}
