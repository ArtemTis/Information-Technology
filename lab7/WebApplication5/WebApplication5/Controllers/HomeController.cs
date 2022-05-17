using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if(ModelState.IsValid)
            {
                WebService client = new WebService();
                client.AddGuest(guest.Name, guest.Email, guest.Phone, guest.WillAttend);
                return View("Thanks", guest);
            }
            else
            {
                //Обнаружена ошибка проверки достоверности
                return View();
            }
        }


    }
}