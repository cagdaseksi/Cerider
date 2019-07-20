using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        u7666632_dbEkinZahireEntities db = new u7666632_dbEkinZahireEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserEntity model)
        {

            var user = new CeriderUser()
            {
                Adress = model.Adress,
                BirthDate = model.BirthDate,
                City = model.City,
                CreatedDate = DateTime.Now,
                Email = model.Email,
                FullName = model.FullName,
                Job = model.Job,
                Phone = model.Phone,
                Status = 0,
                Town = model.Town
            };

            db.CeriderUsers.Add(user);
            db.SaveChanges();

            ViewBag.Message = string.Format("<div class=\"alert alert-success text-center\"><strong> ÇERİDER</strong> {0}.</div>", "Üyeliğiniz oluşturulmuştur Teşekkürler.");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}