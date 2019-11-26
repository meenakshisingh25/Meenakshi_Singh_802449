using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Authenticateservice.Models
{
    public class user
    {
        [Key]
        public string User_Id { get; set; }
        [Required]
        [StringLength(30)]
        public string User_Name { get; set; }

        public string User_Email { get; set; }

        public string User_Mobile { get; set; }
        [Required]
        [StringLength(10)]
        public string User_Password { get; set; }
    }
}
