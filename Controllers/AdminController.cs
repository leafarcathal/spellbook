using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spellbook.Controllers
{
    public class AdminController : Controller
    {
        public const string SessionName = "_Name";
        public const string SessionId = "_Id";
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionId))){
                return RedirectToAction("Home");
            }
            return View();
        }
    }
}
