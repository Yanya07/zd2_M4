using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class WeightedProduct : ITovar
    {
        private string name;
        private decimal pricePerKg;
        private decimal weightInKg;

        public WeightedProduct(string name, decimal pricePerKg, decimal weightInKg)
        {
            this.name = name;
            this.pricePerKg = pricePerKg;
            this.weightInKg = weightInKg;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetPrice()
        {
            return pricePerKg;
        }

        public int GetStock()
        {
            return (int)(weightInKg * 1000); // Возвращаем в граммах
        }

        public void Restock(int quantity)
        {
            weightInKg += quantity / 1000.0m; // Пополняем в кг
        }

        public void Sell(int quantity)
        {
            decimal weightToSell = quantity / 1000.0m;
            if (weightToSell <= weightInKg)
            {
                weightInKg -= weightToSell;
            }
            else
            {
                throw new Exception("Недостаточно товара на складе.");
            }
        }
    }
}
