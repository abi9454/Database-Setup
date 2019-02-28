using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SP19.P2.Web.Models;

namespace SP19.P2.Web.DatabaseContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<SP19.P2.Web.Models.User> Users { get; set; }
        public DbSet<SP19.P2.Web.Models.Role> Roles { get; set; }
        public DbSet<SP19.P2.Web.Models.Customer> Customers { get; set; }
        public DbSet<SP19.P2.Web.Models.PaymentOption> PaymentOptions{ get; set; }
        public DbSet<SP19.P2.Web.Models.Receipt> Receipts{ get; set; }
        public DbSet<SP19.P2.Web.Models.LineItem> LineItems{ get; set; }
        public DbSet<SP19.P2.Web.Models.Table> Tables{ get; set; }
        public DbSet<SP19.P2.Web.Models.TableFoodItem> TableFoodItems{ get; set; }
        public DbSet<SP19.P2.Web.Models.TableBill> TableBills{ get; set; }
        public DbSet<SP19.P2.Web.Models.Menu> Menus{ get; set; }
        public DbSet<SP19.P2.Web.Models.MenuItem> MenuItems { get; set; }

        
        
    }
}
