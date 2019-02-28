using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SP19.P2.Web.Models;

namespace SP19.P2.Web.DatabaseContext
{
    public class MenuSeed
    {
        public static void SeedDb(DataContext context)
        {
            context.Menus.AddRange(
                new Menu()
                {
                    Name = "Lunch menu"
                },
                new Menu()
                {
                    Name = "Entre menu"
                },
                new Menu()
                {
                    Name = "Desert menu"
                }
                
            );
            context.SaveChanges();
        }
    }
}
