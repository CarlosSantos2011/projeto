using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLoja2.DAO;
using WebLoja2.Models;

namespace WebLoja2.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(String Login, String Senha)
        {
           FuncionariosDAO dao = new FuncionariosDAO();
           Funcionario funcionario= dao.Busca(Login, Senha);
            if (funcionario != null)
            {
                Session["usuarioLogado"] = funcionario;
                return RedirectToAction("Index", "Modulos");

            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        public ActionResult Sair ()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}