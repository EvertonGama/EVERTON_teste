using Everton_teste.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Everton_teste.Controllers
{
    public class PassageirosController : Controller
    {
        // GET: Passageiros
        public ActionResult Index()
        {
            List<Models.Passageiros_Grid> _list = new List<Models.Passageiros_Grid>();

            PassageirosBLL bll = new PassageirosBLL();
            _list = bll.GetGrid();

            return View(_list);
        }


        [HttpGet]
        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Models.Passageiros_Novo req)
        {
            PassageirosBLL bll = new PassageirosBLL();
            bll.Salvar(req);
            return View();
        }
    }
}