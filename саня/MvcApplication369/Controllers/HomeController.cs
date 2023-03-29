using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
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
        public ViewResult RsvpForm(GuestResponse x)
        {
            switch (x.Operation)
            {
                case "+":
                    x.Result = (sbyte)(x.Operand1 + x.Operand2);
                    break;
                case "-":
                    x.Result = (sbyte)(x.Operand1 - x.Operand2);
                    break;
                case "*":
                    x.Result = (sbyte)(x.Operand1 * x.Operand2);
                    break;
                case "/":
                    x.Result = (sbyte)(x.Operand1 / x.Operand2);
                    break;
            }
            ViewBag.Result = 24;
            return View("Thanks", x);
        }
    }
}