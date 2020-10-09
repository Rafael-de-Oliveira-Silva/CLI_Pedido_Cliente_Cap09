using System.Globalization;

namespace Exercicio_Fixacao_Cap09.Entities
{
    class OrderItem
    {
        private int Quantity { get; set; }

        private double Price { get; set; }

        private Product ProductItem { get; set; }

        public OrderItem(int quantity, double price, Product productItem)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.ProductItem = productItem;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public double GetPrice()
        {
            return Price;
        }

        public double SubTotal()
        {
            return (Quantity * Price);
        }

        public Product GetProduct()
        {
            return ProductItem;
        }

        public override string ToString()
        {
            return "R$ "+Price.ToString("F2",CultureInfo.InvariantCulture)+
                   ", Quantidade: "+Quantity+", Subtotal: R$ "+SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
