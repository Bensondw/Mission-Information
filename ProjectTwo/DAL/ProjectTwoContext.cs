using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectTwo.Models;
using System.Data.Entity;

namespace ProjectTwo.DAL
{
    public class ProjectTwoContext : DbContext
    {
        public ProjectTwoContext() : base("ProjectTwoContext") {}

        public DbSet<Missions> Missions {get; set;}
        public DbSet<Users> Users {get; set;}
        public DbSet<MissionQuestions> MissionQuestions {get; set;}
    }
}




