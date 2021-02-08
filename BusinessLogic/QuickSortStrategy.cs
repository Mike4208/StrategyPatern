using StrategyPatern_T_Shirt.Interface;
using StrategyPatern_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.BusinessLogic
{
    class QuickSortStrategy : ISortStrategy
    {

        static void QuickSortBySizeAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizePartitionAscending(tShirts, low, high);

                QuickSortBySizeAscending(tShirts, low, pi - 1);
                QuickSortBySizeAscending(tShirts, pi + 1, high);
            } 
        }

        static int QuickSortBySizePartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than the pivot 
                if (tShirts[j].Size < pivot.Size)
                {
                    i++;
                    Swap(tShirts, i, j);
                }
            }

            Swap(tShirts, i + 1, high);
            return i + 1;
        }

        static void QuickSortBySizeDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizePartitionDescending(tShirts, low, high);

                QuickSortBySizeDescending(tShirts, low, pi - 1);
                QuickSortBySizeDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizePartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than the pivot 
                if (tShirts[j].Size > pivot.Size)
                {
                    i++;
                    Swap(tShirts, i, j);
                }
            }
           
            Swap(tShirts, i + 1, high);
            return i + 1;
        }



        static void QuickSortByColorAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByColorPartitionAscending(tShirts, low, high);

                QuickSortByColorAscending(tShirts, low, pi - 1);
                QuickSortByColorAscending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByColorPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than the pivot 
                if (tShirts[j].Color < pivot.Color)
                {
                    i++;
                    Swap(tShirts, i, j);
                }
            }
            
            Swap(tShirts, i + 1, high);
            return i + 1;
        }

        static void QuickSortByColorDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByColorPartitionDescending(tShirts, low, high);

                QuickSortByColorDescending(tShirts, low, pi - 1);
                QuickSortByColorDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByColorPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than the pivot 
                if (tShirts[j].Color > pivot.Color)
                {
                    i++;
                    Swap(tShirts, i, j);
                }
            }

            Swap(tShirts, i + 1, high);
            return i + 1;
        }



        static void QuickSortByFabricAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByFabricPartitionAscending(tShirts, low, high);

                QuickSortByFabricAscending(tShirts, low, pi - 1);
                QuickSortByFabricAscending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByFabricPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than the pivot 
                if (tShirts[j].Fabric < pivot.Fabric)
                {
                    i++;
                    Swap(tShirts, i, j);
                }
            }

            Swap(tShirts, i + 1, high);
            return i + 1;
        }

        static void QuickSortByFabricDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByFabricPartitionDescending(tShirts, low, high);

                QuickSortByFabricDescending(tShirts, low, pi - 1);
                QuickSortByFabricDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortByFabricPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than the pivot 
                if (tShirts[j].Fabric > pivot.Fabric)
                {
                    i++;
                    Swap(tShirts, i, j);
                }
            }
            Swap(tShirts, i + 1, high);
            return i + 1;
        }



        static void QuickSortBySizeThenByColorThenByFabricAscending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizeThenByColorThenByFabricPartitionAscending(tShirts, low, high);

                QuickSortBySizeThenByColorThenByFabricAscending(tShirts, low, pi - 1);
                QuickSortBySizeThenByColorThenByFabricAscending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizeThenByColorThenByFabricPartitionAscending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than the pivot 
                if (tShirts[j].Size < pivot.Size)
                {
                    i++;
                    Swap(tShirts, i, j);
                }
                else if (tShirts[j].Size == pivot.Size)
                {
                    // than the pivot 
                    if (tShirts[j].Color < pivot.Color)
                    {
                        i++;
                        Swap(tShirts, i, j);
                    }
                    else if (tShirts[j].Color == pivot.Color)
                    {
                        // than the pivot 
                        if (tShirts[j].Fabric < pivot.Fabric)
                        {
                            i++;
                            Swap(tShirts, i, j);
                        }
                    }
                }
            }

            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }

        static void QuickSortBySizeThenByColorThenByFabricDescending(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizeThenByColorThenByFabricPartitionDescending(tShirts, low, high);

                QuickSortBySizeThenByColorThenByFabricDescending(tShirts, low, pi - 1);
                QuickSortBySizeThenByColorThenByFabricDescending(tShirts, pi + 1, high);
            }
        }

        static int QuickSortBySizeThenByColorThenByFabricPartitionDescending(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than the pivot 
                if (tShirts[j].Size > pivot.Size)
                {
                    i++;
                    Swap(tShirts, i, j);
                }
                else if (tShirts[j].Size == pivot.Size)
                {
                    if (tShirts[j].Color > pivot.Color)
                    {
                        i++;
                        Swap(tShirts, i, j);
                    }
                    else if (tShirts[j].Color == pivot.Color)
                    {
                        // than the pivot 
                        if (tShirts[j].Fabric > pivot.Fabric)
                        {
                            i++; 
                            Swap(tShirts, i, j);
                        }
                    }
                }
            }

            Swap(tShirts, i + 1, high);
            return i + 1;
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
            QuickSortByColorAscending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortByFabricAscending(List<TShirt> tShirts)
        {
            QuickSortByFabricAscending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortByFabricDescending(List<TShirt> tShirts)
        {
            QuickSortByFabricDescending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortBySizeAscending(List<TShirt> tShirts)
        {
            QuickSortBySizeAscending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortBySizeDescending(List<TShirt> tShirts)
        {
            QuickSortBySizeDescending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortBySizeThenColorAscending(List<TShirt> tShirts)
        {
            QuickSortBySizeThenByColorThenByFabricAscending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortBySizeThenColorDescending(List<TShirt> tShirts)
        {
            QuickSortBySizeThenByColorThenByFabricDescending(tShirts, 0, tShirts.Count - 1);
        }

        public void SortByColorDescending(List<TShirt> tShirts)
        {
            QuickSortByColorDescending(tShirts, 0, tShirts.Count - 1);
        }
    }
}
