﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MOD.TrainingService.Models;

namespace MOD.Userservice.Models
{
    public class Mentor
    {    [Key]
        public string Mentor_id { get; set; }
        [Required]
        public string Mentor_name { get; set; }

        [Required]
        public string Mentor_Email { get; set; }
        [Required]
        [StringLength(10)]
        public string Mentor_Password { get; set; }
        public string Mentor_ContactNo { get; set; }
        [Required]
        public string Mentor_exp { get; set; }

        public string Mentor_Primary_Skill { get; set; }

        public string Mentor_timeslot { get; set; }

         //public bool Mentor_availability { get; set; }

        public bool Mentor_Active { get; set; }
        public string Role { get; set; }
        public string Mentor_LinkedInUrl { get; set; }
        public string Mentor_facility { get; set; }

        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
