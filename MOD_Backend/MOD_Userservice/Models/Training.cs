using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MOD.Userservice.Models
{
    public class Training
    {[Key]
        public string Training_ID { get; set; }
        [Required]
        public string Training_Name { get; set; }
        [ForeignKey("user")]
        public string User_ID { get; set; }
        public string User_Name { get; set; }
        [ForeignKey("Mentor")]
        public string Mentor_ID { get; set; }
        public string Mentor_Name { get; set; }
        [ForeignKey("Skill")]
        public string Skill_ID { get; set; }
        public string Skill_Name { get; set; }

        public Nullable<System.DateTime> Training_StartDate { get; set; }

        public DateTime? Training_EndDate { get; set; }

        public string Training_timeslot { get; set; }

        public string Training_status { get; set; }

        public string Training_Progress { get; set; }

        public string Training_rating { get; set; }
        public int Training_duration { get; set; }
        public Nullable<bool> Requested { get; set; }
        public Nullable<bool> RejectNotify { get; set; }
        public Nullable<bool> Payment_Status { get; set; }

        public user user { get; set; }
        public Mentor Mentor { get; set; }

        public Skill Skill { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

    }
}
