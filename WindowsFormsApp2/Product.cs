using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Product : ITovar
    {
        private string name;
        private decimal price;
        private int stock;

        public Product(string name, decimal price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }

        public void Restock(int quantity)
        {
            stock += quantity;
        }

        public void Sell(int quantity)
        {
            if (quantity <= stock)
            {
                stock -= quantity;
            }
            else
            {
                throw new Exception("Недостаточно товара на складе.");
            }
        }
    }
}