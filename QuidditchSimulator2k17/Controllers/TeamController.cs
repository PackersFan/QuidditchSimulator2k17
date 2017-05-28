using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuidditchSimulator2k17.DataAccessLayer;
using QuidditchSimulator2k17.Models;

namespace QuidditchSimulator2k17.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult registerNewTeam()
        {


            return View("addNewTeam");
        }

        public ActionResult submitNewTeam(Team newTeam)
        {
            DAL dal = new DAL();
            dal.registerTeam(newTeam.name, newTeam.school, "", 1, 0);

            return View("Index");
        }
    }
}