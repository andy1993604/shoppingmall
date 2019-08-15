using Microsoft.EntityFrameworkCore;
using ShopingMall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;


namespace ShopingMall.Data
{
    public class ShoppingMallContext:DbContext
    {
        public ShoppingMallContext(DbContextOptions<ShoppingMallContext> options) : base(options)
        {
        }

        public DbSet<UserProfile> UserProfile { get; set; }
    
}
}
