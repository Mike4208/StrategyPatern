using StrategyPatern_T_Shirt.BusinessLogic;
using StrategyPatern_T_Shirt.Interface;
using StrategyPatern_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.RunProgram
{
    class Store
    {
        public static void BuyTShirts()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int fabric, size, color, paymentMethod;

            Menu menu = new Menu();
            while (true)
            {
                menu.FabricMenu();
                while (!(int.TryParse(Console.ReadLine(), out fabric) && (fabric >= 1 && fabric <= 7)))
                    menu.DisplayMenu(1);
                Console.WriteLine();

                menu.ColorMenu();
                while (!(int.TryParse(Console.ReadLine(), out color) && (color >= 1 && color <= 7)))
                    menu.DisplayMenu(2);
                Console.WriteLine();

                menu.SizeMenu();
                while (!(int.TryParse(Console.ReadLine(), out size) && (size >= 1 && size <= 7)))
                    menu.DisplayMenu(3);
                Console.WriteLine();

                TShirt tshirt = new TShirt((Color)(color - 1), (Size)(size - 1), (Fabric)(fabric - 1));
                menu.PaymentMenu();
                while (!(int.TryParse(Console.ReadLine(), out paymentMethod) && (paymentMethod >= 1 && paymentMethod <= 3)))
                    menu.DisplayMenu(4);
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
                Console.WriteLine("Do you want to by another T-Shirt? (yes/no)");
                string answer = Console.ReadLine();
                Console.Clear();
                if (!answer.Equals("yes"))
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
