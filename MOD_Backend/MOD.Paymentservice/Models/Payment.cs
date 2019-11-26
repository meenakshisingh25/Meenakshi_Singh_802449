using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MOD.Paymentservice.Models
{
    public class Payment
    {[Key]
        public string Payment_Id { get; set; }
        public string Payment_amount { get; set; }

        public string User_Id { get; set; }

        public string User_Name { get; set; }

        public string Mentor_Id { get; set; }
        public string Mentor_Name { get; set; }
        public string Training_Id { get; set; }

        public Nullable<double> Mentor_Amount { get; set; }
    }
}
