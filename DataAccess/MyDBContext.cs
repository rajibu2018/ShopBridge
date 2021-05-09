using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) :base(options) {
        }

        public DbSet<ShopBridgeUserModel> ShopBridgeUsers { get; set; }
        public DbSet<ShopBridgeItemModel> ShopBridgeItems { get; set; }
    }
}
