using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    public class Student
    {
        public int MyProperty { get; set; }
        /// <summary>
        /// The legal name. First Last
        /// ex. J Doe
        /// </summary>
        [Required(ErrorMessage = "Gimme that name!")]
        [Display(Name = "Full Legal Name")]
        public string FullName { get; set; }
        /// <summary>
        /// The program the student intends 
        /// to complete
        /// </summary>

        [Required]
        [Display(Name = "Choose Program")]
        public string ProgramOfChoice { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        //Max 30 chars just for demo
        [StringLength(30, MinimumLength = 5)]
        public string HomeAddress { get; set; }
    }
}
