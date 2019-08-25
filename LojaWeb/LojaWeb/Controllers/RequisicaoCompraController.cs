using LojaWeb.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaWeb.Controllers
{
    public class RequisicaoCompraController : Controller
    {
        // GET: RequisicaoCompra
        public ActionResult Index()
        {
            return View();
        }
        private void EnviaEmailRequisicao()
        {
            var sendMail = new SendMail();
            sendMail.CC = "To";
            sendMail.From = "carloseduardosantos2011@gmail.com";
            sendMail.Body = string.Format("Produto:{0} Quantidade:{1} Data:{2}", ViewBag.Produto, ViewBag.Quantidade, DateTime.Now);
            sendMail.IsBodyHtml = true;
            sendMail.Subject = "Requisição de Compra";
            sendMail.Password = "20122001";
            sendMail.UseSsl = true;
            sendMail.SmtpServerAddress = "smtp.gmail.com";
            sendMail.SmtpServerPort = 587;

            sendMail.Send();
        }
        public ActionResult RequisicaoCompra()
        {
        
            try
            {
                EnviaEmailRequisicao();

                return RedirectToAction("Index"); 
            }
            catch
            {
                return null;
            }
        

        }
      
    }
}