using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SundayTechTest.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Display(Name = "City")]
        public string City { get; set; }

        [StringLength(10)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [StringLength(2)]
        [Display(Name = "Age")]
        public string Age { get; set; }

        [StringLength(50)]
        [Display(Name = "Email Addess")]
        public string EmailAddress { get; set; }


        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}