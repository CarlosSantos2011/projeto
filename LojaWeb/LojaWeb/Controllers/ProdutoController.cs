using LojaWeb.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLoja2.Context;
using WebLoja2.DAO;
using WebLoja2.Models;

namespace WebLoja2.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index ()
        {
            return View();
        }
        public ActionResult Form ()
        {
            ViewBag.Produto = new ProdutosDAO().Lista();
            

            return View();
        }
        public ActionResult Cadastra()
        {
           return RedirectToAction ("Cadastra", "Produto");
        }
        [HttpPost]
        public ActionResult Adiciona(Produtos produto)
        {
            
            ProdutosDAO dao = new ProdutosDAO();
            dao.Adicionar(produto);

            return RedirectToAction("Form");
        }
        
        public void Notificacao (Produtos produtos)
        {
            if (produtos.Quantidade < 5){

                SendMail email = new SendMail();
                email.Send();
            }
            else
            {
                
            }


        }
        public JsonResult Excluir(string ProdutoId)
        {
            
            
                var produto = new ProdutosDAO();
                produto.ExcluirId(int.Parse(ProdutoId));
                return Json(new { Mensagem = "Excluido com sucesso! " }, JsonRequestBehavior.AllowGet);

            
        
        }

    }
}