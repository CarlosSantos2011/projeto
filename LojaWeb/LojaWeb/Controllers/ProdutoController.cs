﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}