using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectTwo.Models
{
    public class MissionMission
    {
        //this represents the query i will do to return data from missions and missionQuestions tables

        //i will need all the info from missions to display info about the mission, and then question and answer from missionQuestions

        [Key]
        public int missionID { get; set; }

        public String question { get; set; }

        public String answer { get; set; }

        [Required]
        public int missionQuestionID { get; set; }

        public String userID { get; set; }

        public String asker { get; set; }

        public String answerer { get; set; }
    }
}
