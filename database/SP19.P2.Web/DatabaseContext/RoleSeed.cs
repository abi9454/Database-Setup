using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using SP19.P2.Web.Models;

namespace SP19.P2.Web.DatabaseContext
{
    public class RoleSeed
    {
        public static void SeedDb(DataContext context)
        {
            context.Roles.AddRange(
                new Role()
                {
                   Name ="Manager"
                },
                new Role()
                {
                    Name = "Admin"
                },
                new Role()
                {
                    Name = "Customer"
                },
                new Role()
                {
                    Name = "Server"
                }
                );
            context.SaveChanges();
        }
    }
}
