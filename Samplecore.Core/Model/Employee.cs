using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Samplecore.Core.Model
{
   
        public class employee
        {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "required")]
        public string? FirstName { get; set; }
       
        public string? MiddleName { get; set; }
            public string? LastName { get; set; }
            public string? Course { get; set; }
            public string? Gender { get; set; }

            public long Phone { get; set; }
            public string? Address { get; set; }
            public string? Email { get; set; }
            public long Password { get; set; }
            public long Repassword { get; set; }

        }
    }

