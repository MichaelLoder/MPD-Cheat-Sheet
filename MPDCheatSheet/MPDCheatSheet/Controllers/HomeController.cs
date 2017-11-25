using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;

namespace MPDCheatSheet.Controllers
{
    public class HomeController : Controller
    {
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "MPD CheatSheet";
        public ActionResult Index()
        {
            using (WebClient wc = new WebClient())
            {
                string priceList = wc.DownloadString("https://docs.google.com/spreadsheets/d/1Ymd53PN1UOcAKrPEIvWpTOWoiY9aAZQUTpHAYSU5dj0/edit#gid=1326130952&fmcmd=4");
                string[] lines = priceList.Split('\n');
            }
            return View();
        }

        public ActionResult TenCodes()
        {
           

            return View();
        }

        public ActionResult MirandaRights()
        {

            return View();
        }
    }
}