using ProjectTwo.DAL;
using ProjectTwo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProjectTwo.Controllers
{
    public class HomeController : Controller
    {

        private ProjectTwoContext db = new ProjectTwoContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Whether you have a question or suggestion, we would love to hear from you";

            return View();
        }

        public ActionResult Missions()
        {
            return View(db.Missions.ToList());
        }

        

        [Authorize]
        public ActionResult MissionFAQs(int missionID)
        {
            
            //this creates the object of the mission based on the paramter missionID
            Missions mission = db.Missions.Find(missionID);
            //this fills the ViewBag with all the mission object attributes
            ViewBag.mission = mission;
                        
            //query
            IEnumerable<MissionMission> randomWord = db.Database.SqlQuery<MissionMission>
            (
            "Select MissionQuestions.question, MissionQuestions.answer, MissionQuestions.missionQuestionID " +

            "From MissionQuestions " +

            "Where MissionQuestions.missionID = " + missionID 
            );


               
            return View(randomWord);
        }


        [HttpPost]
        public ActionResult MissionFAQs(FormCollection form, int id)
        {

            MissionQuestions q = db.MissionQuestions.Find(id);

            String form_answer = form["answer"].ToString();

            q.answer = form_answer;

            db.SaveChanges();

                      




            return RedirectToAction("MissionFAQs", new { missionID = q.missionID });
        }


        /* this code below was for when I was using the EDIT scaffolded forms adapted for this
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MissionFAQs([Bind(Include = "missionQuestionID,missionID,userID,question,answer")] MissionQuestions missionQuestions)
        {
            if (ModelState.IsValid)
            {
                db.MissionQuestions.Add(missionQuestions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missionQuestions);

        }
        */


        //the whole create section below is for creating new questions
        // GET: MissionQuestions/Create
        public ActionResult Create(int missionID)
        {

            ViewBag.missionID = missionID;
           

            return View();
        }

        // POST: MissionQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "missionQuestionID,missionID,userID,question,answer")] MissionQuestions missionQuestions)
        {
            if (ModelState.IsValid)
            {
                db.MissionQuestions.Add(missionQuestions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missionQuestions);
        }


       

        


       
    }
}