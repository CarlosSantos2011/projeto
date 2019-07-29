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
                produto.Adicionar(new Models.Produtos { Nome = "Carregador", Valor = 25.99, Categoria = "Acessório", TempoGarantia=30, Modelo= "Kingoo", Quantidade = 20  });
                var Produto = produto.Lista().First();


                ClientesDAO cliente = new ClientesDAO();
                cliente.Adicionar(new Venda { Nome = "Carlos", Cpf = "124.487.479-54" });
                var Cliente = cliente.Lista().First();


                ClientesDAO cliente2 = new ClientesDAO();
                cliente.Adicionar(new Venda { Nome = "Diego", Cpf = "054.487.929-52" });
                var Cliente2= cliente.Lista().First();


            };
            
            return View();
        }
    }
}