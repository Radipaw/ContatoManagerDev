using ContatoManagerDev.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContatoManagerDev.Controllers
{
    public class HomeController : Controller
    {
        private ContatoDevDB db = new ContatoDevDB();

        public ActionResult Index()
        {
            var contatos = db.Contatos.ToList();
            return View(contatos);
        }
    }
}