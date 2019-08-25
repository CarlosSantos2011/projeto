using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLoja2.Context;
using WebLoja2.DAO;
using WebLoja2.Models;

namespace LojaWeb.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            ViewBag.Usuario = new UsuariosDAO().Lista();
            return View();
        }
        [HttpPost]
        public ActionResult Adiciona(Usuario usuario)
        {

            UsuariosDAO dao = new UsuariosDAO();
            dao.Adicionar(usuario);

            return RedirectToAction("Index");
        }
    }
}