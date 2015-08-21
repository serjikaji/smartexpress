using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartExpressUI.Areas.Client.Controllers
{
    public class PackageHistoryController : Controller
    {
        private ClientBs objBs;

        public PackageHistoryController()
        {
            objBs = new ClientBs();
        }
        // GET: Client/PackageHistory
        public ActionResult Index()
        {
            var client = objBs.GetAll();

            return View(client);
        }
    }
}