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
        public ActionResult ListaProduto()
        {
            return RedirectToAction("Form", "Produto");
        }
        public ActionResult Venda()
        {
            return RedirectToAction("Index", "Venda");
        }
        public ActionResult CompraProduto()
        {
            return RedirectToAction("Index", "Compra");
        }
        public ActionResult Relatorios()
        {
            return RedirectToAction("Index", "Relatorio");
        }
        public ActionResult CadastroUsuario()
        {
            return RedirectToAction("Index", "Usuario"); 
        }
        public ActionResult ComprasEmAberto()
        {
            return RedirectToAction("Index", "RequisicaoCompra");
        }
        
    }
}