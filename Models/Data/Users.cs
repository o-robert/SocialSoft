using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSoft.Models.Data
{
    public class Users
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_id { get; set; }

        [Required(ErrorMessage="Enter a valid username")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Enter a valid Password")]
        public string Password { get; set; }
    }
}
