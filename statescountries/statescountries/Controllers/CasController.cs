using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using statescountries.Models;

namespace statescountries.Controllers
{
    public class CasController : Controller
    {
        statescountriesEntities db = new statescountriesEntities();
        // GET: Cas
        public ActionResult Index()
        {
            ViewBag.countrylist = new SelectList(GetCountryList(),"countriesid","country1");
            return View();
        }

        public List<country> GetCountryList()
        {
            List<country> countries = db.countries.ToList();
            return countries;
        }

        public ActionResult GetStateList(int cid)
        {
            List<state> selectlist = db.states.Where(x => x.countryid == cid).ToList();
            ViewBag.slist = new SelectList(selectlist, "stateid", "state1");
            return PartialView("displaystates");
        }


    }
}