using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TShirt
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int fabric, size, color, paymentMethod;
            Menu menu = new Menu();

            while (true)
            {
                menu.FabricMenu();
                while (!(int.TryParse(Console.ReadLine(), out fabric) && (fabric >= 1 && fabric <= 7)))
                {
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine();
                    menu.FabricMenu();
                }
                Console.WriteLine();

                menu.ColorMenu();
                while (!(int.TryParse(Console.ReadLine(), out color) && (color >= 1 && color <= 7)))
                {
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine();
                    menu.ColorMenu();
                }
                Console.WriteLine();

                menu.SizeMenu();
                while (!(int.TryParse(Console.ReadLine(), out size) && (size >= 1 && size <= 7)))
                {
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine();
                    menu.SizeMenu();
                }
                Console.WriteLine();

                TShirt tshirt = new TShirt((Color)(color - 1), (Size)(size - 1), (Fabric)(fabric - 1));

                menu.PaymentMethodMenu();
                while (!(int.TryParse(Console.ReadLine(), out paymentMethod) && (paymentMethod >= 1 && paymentMethod <= 3)))
                {
                    Console.WriteLine("Wrong choice!");
                    Console.WriteLine();
                    menu.PaymentMethodMenu();
                }
                Console.WriteLine();

                IPaymentStrategy paymentStrategy = null;

                switch (paymentMethod)
                {
                    case 1:
                        paymentStrategy = new CreditCardPaymentStrategy();
                        break;
                    case 2:
                        paymentStrategy = new BankTransferPaymentStrategy();
                        break;
                    case 3:
                        paymentStrategy = new CashPaymentStrategy();
                        break;
                }

                tshirt.SetPaymentStrategy(paymentStrategy);
                tshirt.Pay();
                Console.WriteLine();
                Console.WriteLine("Do you want to buy another T-Shirt? (yes/no)");
                string answer = Console.ReadLine();
                if (!answer.Equals("yes"))
                {
                    break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
