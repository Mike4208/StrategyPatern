using StrategyPatern_T_Shirt.Interface;
using StrategyPatern_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.BusinessLogic
{
    class BubbleSortStrategy : ISortStrategy
    {
        public static void BubleSortBySizeAscending(List<TShirt> tShirts)
        {
            int n = tShirts.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tShirts[j].Size > tShirts[j + 1].Size)
                        Swap(tShirts, j, j + 1);
        }

        public static void BubleSortBySizeDescending(List<TShirt> tShirts)
        {
            int n = tShirts.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tShirts[j].Size < tShirts[j + 1].Size)
                        Swap(tShirts, j, j + 1);
        }



        public static void BubleSortByColorAscending(List<TShirt> tShirts)
        {
            int n = tShirts.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tShirts[j].Color > tShirts[j + 1].Color)
                        Swap(tShirts, j, j + 1);
        }

        public static void BubleSortByColorDescending(List<TShirt> tShirts)
        {
            int n = tShirts.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tShirts[j].Color < tShirts[j + 1].Color)
                        Swap(tShirts, j, j + 1);
        }



        public static void BubleSortByFabricAscending(List<TShirt> tShirts)
          {
            int n = tShirts.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tShirts[j].Fabric > tShirts[j + 1].Fabric)
                        Swap(tShirts, j, j + 1);
        }

        public static void BubleSortByFabricDescending(List<TShirt> tShirts)
        {
            int n = tShirts.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tShirts[j].Fabric < tShirts[j + 1].Fabric)
                        Swap(tShirts, j, j + 1);
        }



        public static void BubleSortBySizeThenByColorThenByFabricAscending(List<TShirt> tShirts)
        {
            int n = tShirts.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tShirts[j].Size > tShirts[j + 1].Size)
                        Swap(tShirts, j, j + 1);
                    else if (tShirts[j].Size == tShirts[j + 1].Size)
                    {
                        if (tShirts[j].Color > tShirts[j + 1].Color)
                            Swap(tShirts, j, j + 1);
                        else if (tShirts[j].Color == tShirts[j + 1].Color)
                        {
                            if (tShirts[j].Fabric > tShirts[j + 1].Fabric)
                                Swap(tShirts, j, j + 1);
                        }
                    }
        }

        public static void BubleSortBySizeThenByColorThenByFabricDescending(List<TShirt> tShirts)
        {
            int n = tShirts.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (tShirts[j].Size < tShirts[j + 1].Size)
                        Swap(tShirts, j, j + 1);
                    else if (tShirts[j].Size == tShirts[j + 1].Size)
                    {
                        if (tShirts[j].Color < tShirts[j + 1].Color)
                            Swap(tShirts, j, j + 1);
                        else if (tShirts[j].Color == tShirts[j + 1].Color)
                        {
                            if (tShirts[j].Fabric < tShirts[j + 1].Fabric)
                                Swap(tShirts, j, j + 1);
                        }
                    }
        }



        static void Swap(List<TShirt> input, int i, int j)
        {
            TShirt temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }


        public void PrintTShirts(List<TShirt> tShirts)
        {
            foreach (var tShirt in tShirts)
            {
                Console.WriteLine(tShirt.ToString());
            }
        }


        public void SortByColorAscending(List<TShirt> tShirts)
        {
            BubleSortByColorAscending(tShirts);
        }

        public void SortByFabricAscending(List<TShirt> tShirts)
        {
            BubleSortByFabricAscending(tShirts);
        }

        public void SortByFabricDescending(List<TShirt> tShirts)
        {
            BubleSortByFabricDescending(tShirts);
        }

        public void SortBySizeAscending(List<TShirt> tShirts)
        {
            BubleSortBySizeAscending(tShirts);
        }

        public void SortBySizeDescending(List<TShirt> tShirts)
        {
            BubleSortBySizeDescending(tShirts);
        }

        public void SortBySizeThenColorAscending(List<TShirt> tShirts)
        {
            BubleSortBySizeThenByColorThenByFabricAscending(tShirts);
        }

        public void SortBySizeThenColorDescending(List<TShirt> tShirts)
        {
            BubleSortBySizeThenByColorThenByFabricDescending(tShirts);
        }

        public void SortByColorDescending(List<TShirt> tShirts)
        {
            BubleSortByColorDescending(tShirts);
        }
    }
}
