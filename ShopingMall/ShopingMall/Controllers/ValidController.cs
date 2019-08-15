using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopingMall.Models;   




namespace ShopingMall.Controllers
{
    public class ValidController : Controller
    {
        private string connStr = @"Data Source = (localdb)\\ProjectsV13;Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult UsRegistered()
        {


            

            List<UserProfile> userDatas = new List<UserProfile>();
            {
               


            }
            //Models.UserData userData = new Models.UserData();
            //userData.UserID ="陳柏維";
            return View();
        }
        //public ActionResult index11()
        //{
        //    using (MyContext db_context = new MyContext())



        //        return View();
        //}
        
    }

 
}
