using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PHARAM.Models;
using System.Net;
using System.Net.Mail;

namespace PHARAM.Controllers
{
    public class HomeController : Controller
    {


        private MyDbContext _context;
        public HomeController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var pharmacies = _context.Pharmacies.ToList();
            return View(pharmacies);
        }

        public ActionResult Contact()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Mail()
        {
            
            MailMessage mailMessage = new MailMessage("medsnoussi0@gmail.com", Request["E-mail"]);
            mailMessage.Subject = Request["Name"];
            mailMessage.Body = Request["Message"];
            mailMessage.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential network = new NetworkCredential("medsnoussi0@gmail.com", "************");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = network;
            smtp.Send(mailMessage);
            
            return View();
        }






        public ActionResult Map(string lat,string lon,string name)
        {
            ViewData["longitude"] = lon;
            ViewData["latitude"] = lat;
            ViewData["name"] = name;
            return View();
        }



    }
}