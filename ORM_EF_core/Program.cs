using ORM_EF_core.Models;
using ORM_EF_core.Services;

namespace ORM_EF_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaSevice pizzaSevice = new PizzaSevice();
            // pizzaSevice.CreatePizza("Sade", 8.20);


            //List<Pizza> pizzas = pizzaSevice.GetAll();
            //foreach(Pizza pizza in pizzas)
            //{
            //    Console.WriteLine(pizza.Name);
            //}


            //    Pizza pizza = pizzaSevice.GetById(3);
            //    if (pizza==null)
            //    {
            //        Console.WriteLine("Bele pizza yoxdur");
            //    }
            //    Console.WriteLine(pizza.Name);

            //pizzaSevice.Remove(2);

            //Size size = new Size();
            
        }
    }
}