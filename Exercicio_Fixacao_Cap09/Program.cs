using System;
using Exercicio_Fixacao_Cap09.Entities;
using System.Globalization;

namespace Exercicio_Fixacao_Cap09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("- Nome: ");
            string nameClient = Console.ReadLine();
            Console.Write("- Email: ");
            string emailClient = Console.ReadLine();
            Console.Write("- Data de Nascimento (DD/MM/YYYY): ");
            DateTime dtBirthClient = DateTime.Parse(Console.ReadLine());
            Client cliente1 = new Client(nameClient, emailClient, dtBirthClient);

            Console.WriteLine();

            Console.WriteLine("Entre com os dados do pedido: ");
            Console.Write("- Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order pedido1 = new Order(DateTime.Now, status, cliente1);

            Console.WriteLine();

            Console.Write("Esse pedido terá quantos itens?: ");
            int qtdItens = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdItens; i++) {
                Console.WriteLine($"Entre com os dados do item # {i+1}:");
                Console.Write("- Nome do produto: ");
                string nameProduto = Console.ReadLine();

                Console.Write("- Preço: ");
                double priceProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("- Quantidade: ");
                int qtdProduto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product produto = new Product(nameProduto, priceProduto);
                OrderItem itemPedido = new OrderItem(qtdProduto, priceProduto, produto);
                pedido1.AddItem(itemPedido);
            }

            Console.WriteLine();

            Console.WriteLine("................RESUMO DO PEDIDO..................");
            Console.WriteLine(pedido1);

        }
    }
}
