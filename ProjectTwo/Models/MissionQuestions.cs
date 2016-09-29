using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectTwo.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        [Required]
        public int missionQuestionID {get; set;}
        
        public int missionID {get; set;}

        public String userID {get; set;}

        public String question {get; set;}

        public String answer {get; set;}

        public String asker { get; set; }

        public String answerer { get; set; }

    }
}





