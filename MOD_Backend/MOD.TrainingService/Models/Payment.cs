using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MOD.TrainingService.Models;

namespace MOD.Userservice.Models
{
    public class Payment
    {[Key]
        public string Payment_Id { get; set; }
        public string Payment_amount { get; set; }
        [ForeignKey("user")]
        public string User_Id { get; set; }

        public string User_Name { get; set; }
        [ForeignKey("Mentor")]
        public string Mentor_Id { get; set; }
        public string Mentor_Name { get; set; }
        [ForeignKey("Training")]
        public string Training_Id { get; set; }

        public Nullable<double> Mentor_Amount { get; set; }
        
        public user user { get; set; }

        public Mentor Mentor { get; set;}

        public Training Training { get; set; }
    }
}
