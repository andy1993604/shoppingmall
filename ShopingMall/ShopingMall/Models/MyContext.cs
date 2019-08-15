using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopingMall.Models;

namespace ShopingMall
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
       public DbSet<UserProfile> Users { get; set; }
        

        //public DbSet<UserProfile> Users { get; set; }
        
    }
}

