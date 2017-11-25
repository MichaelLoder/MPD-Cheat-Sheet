using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace MPDCheatSheet.Controllers
{
    
    public class LawsController : Controller
    {

        private ILawAggregator _lawAggregator;
        public LawsController()
        {
            _lawAggregator = new LawsAggregator();
        }

        public ActionResult GetFelonyCharges()
        {
            try
            {
                return Json(_lawAggregator.GetFelonyCharges(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public ActionResult GetMisdemeanorCharges()
        {
            try
            {
                return Json(_lawAggregator.GetMisdemeanorCharges(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public ActionResult MinorMisdemeanors()
        {
            try
            {
                return Json(_lawAggregator.MinorMisdemeanors(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}