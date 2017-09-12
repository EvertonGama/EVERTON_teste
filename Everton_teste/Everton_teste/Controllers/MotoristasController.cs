using Everton_teste.BLL;
using Everton_teste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Everton_teste.Controllers
{
    public class MotoristasController : Controller
    {
        public ActionResult Index()
        {
            List<Models.Motoristas_Grid> _list = new List<Models.Motoristas_Grid>();

            MotoristasBLL bll = new MotoristasBLL();
            _list = bll.GetGrid();

            return View(_list);
        }

        [HttpGet]
        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Motoristas_Novo req)
        {
            MotoristasBLL bll = new MotoristasBLL();
            bll.Salvar(req);
            return View();
        }
    }
}
