using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Fixacao_Cap09.Entities
{
    class Order
    {
        private DateTime Moment { get; set; }

        private OrderStatus Status { get; set; }

        private Client ClientOrder { get; set; }

        private List<OrderItem> ListOrderItem { get; set; }

        public Order(DateTime moment, OrderStatus status, Client clientOrder)
        {
            this.Moment = moment;
            this.Status = status;
            this.ClientOrder = clientOrder;
            this.ListOrderItem = new List<OrderItem>();
        }

        public void AddItem(OrderItem o)
        {
            this.ListOrderItem.Add(o);
        }

        public void RemoveItem(OrderItem o)
        {
            this.ListOrderItem.Remove(o);
        }

        public double Total()
        {
            double totalOrder = 0;
            foreach (OrderItem item in ListOrderItem)
            {
                totalOrder += item.SubTotal();
            }

            return totalOrder;
        }

        public override string ToString()
        {
            double totalPedido = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data do pedido: " + Moment);
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: "+ ClientOrder.ToString());
            sb.AppendLine("...Itens do pedido...");
            foreach (OrderItem item in ListOrderItem) {
                totalPedido += item.SubTotal();
                sb.AppendLine(item.GetProduct().ToString()+", "+
                    item.ToString());
            }
            sb.AppendLine("-------------------------------");
            sb.AppendLine("Total do pedido: " + totalPedido.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
