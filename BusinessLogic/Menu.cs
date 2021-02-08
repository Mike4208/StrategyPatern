using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.BusinessLogic
{
    class Menu
    {
        public void FabricMenu()
        {
            Console.WriteLine("Pleas select number corresponding to the fabric of the T-Shirt");
            Console.WriteLine("1. WOOL");
            Console.WriteLine("2. COTTON");
            Console.WriteLine("3. POLYESTER");
            Console.WriteLine("4. RAYON");
            Console.WriteLine("5. LINEN");
            Console.WriteLine("6. CASHMERE");
            Console.WriteLine("7. SLIK");
        }

        public void ColorMenu()
        {
            Console.WriteLine("Pleas select number corresponding to the color of the T-Shirt");
            Console.WriteLine("1. RED");
            Console.WriteLine("2. ORANGE");
            Console.WriteLine("3. YELLOW");
            Console.WriteLine("4. GREEN");
            Console.WriteLine("5. BLUE");
            Console.WriteLine("6. INDIGO");
            Console.WriteLine("7. VIIOLET");
        }
        public void SizeMenu()
        {
            Console.WriteLine("Pleas select number corresponding to the size of the T-Shirt");
            Console.WriteLine("1. XS");
            Console.WriteLine("2. S");
            Console.WriteLine("3. M");
            Console.WriteLine("4. L");
            Console.WriteLine("5. XL");
            Console.WriteLine("6. XXL");
            Console.WriteLine("7. XXXL");
        }
        public void PaymentMenu()
        {
            Console.WriteLine("Pleas payment method");
            Console.WriteLine("1. Credit card");
            Console.WriteLine("2. Bank transfer");
            Console.WriteLine("3. Cash");
        }

        public void SortMenu() 
        {
            Console.WriteLine("Pleas select number corresponding to the sorting algorithm");
            Console.WriteLine("1. Quick Sort");
            Console.WriteLine("2. Buble Sort");
            Console.WriteLine("3. Bucket Sort");
        }

        public void SortType()
        {
            Console.WriteLine("Pleas select number corresponding to the sort type");
            Console.WriteLine("1. By Size Ascending");
            Console.WriteLine("2. By Size Descending");
            Console.WriteLine("3. By Color Ascending");
            Console.WriteLine("4. By Color Descending");
            Console.WriteLine("5. By Fabric Ascending");
            Console.WriteLine("6. By Fabric Descending");
            Console.WriteLine("7. By Size Then By Color Ascending");
            Console.WriteLine("8. By Size Then By Color Descending");
        }

        public void DisplayMenu(int menuToDisplay)
        {
            Console.WriteLine("Wrong choice!");
            Console.WriteLine();
            switch (menuToDisplay)
            {
                case 1: FabricMenu(); break;
                case 2: ColorMenu(); break;
                case 3: SizeMenu(); break;
                case 4: PaymentMenu(); break;
                case 5: SortMenu(); break;
                case 6: SortType(); break;
            }
        }
    }
}
