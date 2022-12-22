using ORM_EF_core.DAL;
using ORM_EF_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_EF_core.Services
{
    internal class PizzaSevice
    {
        public Pizza GetById(int id)
        {
            Pizza pizza;
            using(AppDbContext dbContext = new AppDbContext()) 
            { 
              pizza=dbContext.Pizzas.FirstOrDefault(p => p.Id == id);
            }
            return pizza;
        }
        public void CreatePizza(string name, double price)
        {
            Pizza pizza = new Pizza
            {
                Name = name,
                Price = price

            };
           using(AppDbContext context=new AppDbContext())
            {
                context.Pizzas.Add(pizza);
                context.SaveChanges();
                Console.WriteLine("Successfully add");
            }
        }
        public List<Pizza> GetAll()
        {
            List<Pizza> pizzas;
            using(AppDbContext context=new AppDbContext())
            {
                pizzas=context.Pizzas.ToList();

            }
            return pizzas;
        }

        public void Remove(int id)
        {
            Pizza existed;
            using (AppDbContext dbContext = new AppDbContext())
            {
                existed = dbContext.Pizzas.FirstOrDefault(p => p.Id == id);
                if(existed!=null)
                {
                    dbContext.Pizzas.Remove(existed);
                    dbContext.SaveChanges();
                    Console.WriteLine("Successfully deleted");
                }
            }

          
        }
    }
}
