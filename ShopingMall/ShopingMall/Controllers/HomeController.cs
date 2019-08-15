using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopingMall.Models;
using System.Data.SqlClient;
using ShopingMall.Data;

namespace ShopingMall.Controllers
{
    public class HomeController : Controller
    {
        private ShoppingMallContext _context;
        public HomeController(ShoppingMallContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<UserProfile> user = _context.UserProfile.ToList(); //DBcontext傳送過來的物件並不是list，傳過來後要把他轉成List才會一樣
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult test()
        {
            return View("");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
