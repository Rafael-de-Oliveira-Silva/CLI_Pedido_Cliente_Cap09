using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao_Cap09.Entities
{
    class Product
    {
        private string Name { get; set; }

        private double Price { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
