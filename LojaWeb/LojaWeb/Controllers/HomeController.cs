using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebLoja2.DAO;
using WebLoja2.Models;


namespace WebLoja2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            {
                ProdutosDAO produto = new ProdutosDAO();
                produto.Adicionar(new Models.Produtos { Nome = "Carregador", Valor = 25 });
                var Produto = produto.Lista().First();
                    
    

            };
            
            return View();
        }
    }
}