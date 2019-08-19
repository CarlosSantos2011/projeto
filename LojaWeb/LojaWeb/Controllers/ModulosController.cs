using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
    public class ModulosController : Controller
    {
        // GET: Modulos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CadastroPessoa()
        {
            return RedirectToAction("Cadastro", "Pessoa");
        }
        public ActionResult CadastroProduto()
        {
            return RedirectToAction("Index", "Produto");
        }
    }
}