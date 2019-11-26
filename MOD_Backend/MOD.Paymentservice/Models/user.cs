using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MOD.TrainingService.Models;
using MOD.Paymentservice.Models;

namespace MOD.Userservice.Models
{
    public class user
    {[Key]
        public string User_Id { get; set; }
        [Required]
        [StringLength(30)]
        public string User_Name { get; set; }

        public string User_Email { get; set; }

        public string User_Mobile { get; set; }
        [Required]
        [StringLength(10)]
        public string User_Password { get; set; }

        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

        // public Active User_Active;
    }
}
