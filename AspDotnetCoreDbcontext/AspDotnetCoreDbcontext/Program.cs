using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using AspDotnetCoreDbcontext.Models;
namespace AspDotnetCoreDbcontext
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new testContext())
            {
                // Creating a new item and saving it to the database
                var newItem = new Item();
                newItem.Name = "Red Apple";
                newItem.Description = "Description of red apple";
                db.Item.Add(newItem);
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);
                // Retrieving and displaying data
                Console.WriteLine();
                Console.WriteLine("All items in the database:");
                foreach (var item in db.Item)
                {
                    Console.WriteLine("{0} | {1}", item.Name, item.Description);
                }
            }
        }
    }
}
