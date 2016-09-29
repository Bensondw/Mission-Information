using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectTwo.Models
{

    [Table("Missions")]
    public class Missions
    {
        [Key]
        public int missionID { get; set; }

        public String missionName { get; set; }

        public String missionPresidentName { get; set; }

        public String missionAddress { get; set; }

        public String language { get; set; }

        public String climate { get; set; }

        public String dominantReligion { get; set; }

        public String imageRefCountry { get; set; }

        public String imageRefSecondary { get; set; }

        public String imageRefTemple { get; set; }
        
    }
}