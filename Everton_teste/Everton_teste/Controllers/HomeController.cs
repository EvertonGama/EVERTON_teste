using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Everton_teste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BLL.CorridasBLL bll = new BLL.CorridasBLL();
            var model = bll.GetGrid();

            return View(model);
        }
        public ActionResult Novo()
        {
            BLL.MotoristasBLL moto = new BLL.MotoristasBLL();
            BLL.PassageirosBLL pass = new BLL.PassageirosBLL();

            Models.Corrida_Novo model = new Models.Corrida_Novo();
            model.Motoristas = moto.GetSelect();
            model.Passageiros = pass.GetSelect();

            return View(model);
        }
        [HttpPost]
        public ActionResult Novo(Models.Corrida_Novo_Salvar model)
        {
            BLL.CorridasBLL bll = new BLL.CorridasBLL();
            bll.Salvar(model);


            Models.Corrida_Novo modelR = new Models.Corrida_Novo();
            return View(modelR);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}