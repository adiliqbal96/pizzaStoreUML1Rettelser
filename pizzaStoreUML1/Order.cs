using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaStoreUML1
{
    internal class Order
    {
        public Pizza pizza {  get; set; }
        public Customer customer { get; set; }

        public Order(Pizza pizza, Customer customer)
        {
            this.pizza = pizza;
            this.customer = customer;
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = pizza.Price; 
            totalPrice += 40;
            return totalPrice;
        }

        public override string ToString()
        {
            return $"{customer} ordered {pizza}. Total Price with delivery + tax: {CalculateTotalPrice()} kr";
        }
    }
}
