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
    class PerformanceTest
    {
        static List<TShirt> CreateSyntheticData(string message)
        {

            Console.Write("Enter the number of synthetic data " + message + ": ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<TShirt> tShirts = new List<TShirt>();

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int c = rnd.Next(0, 7);
                Color color = (Color)c;
                int s = rnd.Next(0, 7);
                Size size = (Size)s;
                int f = rnd.Next(0, 7);
                Fabric fabric = (Fabric)f;
                tShirts.Add(new TShirt(color, size, fabric));
            }

            return tShirts;
        }

        public static void SortTShirts()
        {
            int sortingAlgorithm, sortingType;
            Menu menu = new Menu();
            while (true)
            {
                List<TShirt> tShirts = CreateSyntheticData("to perform sorting");
                menu.SortMenu();
                while (!(int.TryParse(Console.ReadLine(), out sortingAlgorithm) && (sortingAlgorithm >= 1 && sortingAlgorithm<= 3)))
                    menu.DisplayMenu(5);
                Console.WriteLine();

                menu.SortType();
                while (!(int.TryParse(Console.ReadLine(), out sortingType) && (sortingType>= 1 && sortingType<= 8)))
                    menu.DisplayMenu(6);
                Console.WriteLine();

                ISortStrategy sortStrategy = null;
                switch (sortingAlgorithm)
                {
                    case 1: sortStrategy = new QuickSortStrategy(); break;
                    case 2: sortStrategy = new BubbleSortStrategy(); break;
                    case 3: sortStrategy = new BucketSortStrategy(); break;
                }

                switch (sortingType)
                {
                    case 1: sortStrategy.SortBySizeAscending(tShirts); break;
                    case 2: sortStrategy.SortBySizeDescending(tShirts); break;
                    case 3: sortStrategy.SortByColorAscending(tShirts); break;
                    case 4: sortStrategy.SortByColorDescending(tShirts); break;
                    case 5: sortStrategy.SortByFabricAscending(tShirts); break;
                    case 6: sortStrategy.SortByFabricDescending(tShirts); break;
                    case 7: sortStrategy.SortBySizeThenColorAscending(tShirts); break;
                    case 8: sortStrategy.SortBySizeThenColorDescending(tShirts); break;
                }
                sortStrategy.PrintTShirts(tShirts);
                Console.WriteLine();
                Console.WriteLine("Do you want to perform another Sort? (yes/no)");
                string answer = Console.ReadLine();
                Console.Clear();
                if (!answer.Equals("yes"))
                {
                    break;
                }
                Console.WriteLine();
            }

        }
        public static void CheckSpeedPerformance()
        {
            Menu menu = new Menu();
            while (true)
            {
                List<TShirt> tShirts = CreateSyntheticData("to perform speed test of the sorting algorithms");
                
                ISortStrategy sort = null;
                sort = new QuickSortStrategy();
                PerformSpeedTest(sort, tShirts, "QuickSortStrategy");
                sort = new BubbleSortStrategy();
                PerformSpeedTest(sort, tShirts, "BubbleSortStrategy");
                sort = new BucketSortStrategy();
                PerformSpeedTest(sort, tShirts, "BucketSortStrategy");

                Console.WriteLine("Do you want to perform another Sort? (yes/no)");
                string answer = Console.ReadLine();
                Console.Clear();
                if (!answer.Equals("yes"))
                {
                    break;
                }
                Console.WriteLine();
            }
        }
        static void PerformSpeedTest(ISortStrategy sort, List<TShirt> tShirts, string sortingAlgorithm)
        {
            DateTime start = DateTime.Now;
            sort.SortBySizeAscending(tShirts);
            Console.WriteLine(sortingAlgorithm + ":   Took: {0:00.0000} ms", (DateTime.Now - start).TotalMilliseconds);
        }
    }
}
