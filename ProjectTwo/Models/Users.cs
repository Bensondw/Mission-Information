using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectTwo.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int userID {get;set;}

        public String userEmail {get; set;}

        public String password {get; set;}

        public String firstName {get; set;}

        public String lastName {get; set;}
    }
}


