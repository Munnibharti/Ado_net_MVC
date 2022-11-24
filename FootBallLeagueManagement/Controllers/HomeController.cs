using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using FootBallLeagueManagement.Models;

namespace FootBallLeagueManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //for this we have add namespaces of FootBallLeagueManagement.Models as namespace
        //because we are using its object
        FootballerDbContext db = new FootballerDbContext();
      //  string winteam = "Egland+France+England+Brazil+Russia";
        public ActionResult Index()
            
        {
            //inside FootballLeagues all rows will store inside it so 
            //convert all property of table into list,

            //Table will create with names of FootBallLeagues inside sql
            var data = db.FootBallLeagues.ToList();
            //here waht is happening
            //All data which is inside FootBallLeagues in coming inside Data
            //And passing inside View 
            //Index is used to display data

            return View(data);
            //Now right click on Index and addview.
        }

        //here we are creating create() method for inserting new  value

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FootBallLeague fb)
        {
            
            //here we are adding new inserting value inside dbSet object db which is store in database
          
            //Here

            
            db.FootBallLeagues.Add(fb);
            //this save cahnges return one if code inserted else 0 

            int a = db.SaveChanges();
            if(a> 0)
            {//when we have to display data from controller to view then  we use viewBag or ViewData;
                ViewBag.InsertMessage = "<script>alert('Successfull')</script>";
            }
            else
            {
                ViewBag.InsertMessage = "<script>alert('Data Not Inserted')</script>";
            }
            return View();
        }

    }
}