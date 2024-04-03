using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaStoreUML1
{
    internal class Store
    {
        public void Start()
        {
            Pizza pizza1 = new Pizza("Margherita", 89);
            Pizza pizza2 = new Pizza("Pepperoni", 99);
            Pizza pizza3 = new Pizza("Hawaiian", 109);

            Customer customer1 = new Customer("Alice");
            Customer customer2 = new Customer("Bob");
            Customer customer3 = new Customer("Charlie");

            Order order1 = new Order(pizza1, customer1);
            Order order2 = new Order(pizza2, customer2);
            Order order3 = new Order(pizza3, customer3);

            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
        }
    }
}
