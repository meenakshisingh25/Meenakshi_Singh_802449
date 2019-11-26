using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Userservice.Models
{
    public class Skill
    {[Key]
        public string SkillId { get; set;}
        [Required]
        public string SkillName { get; set; }

        public string TOC { get; set; }

        public string prerequisite { get; set; }

        public double fee { get; set; }
        [Required]
        public int Duration { get; set; }

        public IEnumerable<Skill> Skills
        { get; set; }
    }
}
