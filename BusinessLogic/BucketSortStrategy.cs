using StrategyPatern_T_Shirt.Interface;
using StrategyPatern_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.BusinessLogic
{
    class BucketSortStrategy : ISortStrategy
    {

        public void BucketSortBySizeAscending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
                return;

            Size maxValue = tShirts[0].Size;
            Size minValue = tShirts[0].Size;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Size > maxValue)
                    maxValue = tShirts[i].Size;
                if (tShirts[i].Size < minValue)
                    minValue = tShirts[i].Size;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[tShirts[i].Size - minValue] == null )
                    bucket[tShirts[i].Size - minValue] = new LinkedList<TShirt>();
                bucket[tShirts[i].Size - minValue].AddLast(tShirts[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;
                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void BucketSortBySizeDescending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
                return;

            Size maxValue = tShirts[0].Size;
            Size minValue = tShirts[0].Size;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Size > maxValue)
                    maxValue = tShirts[i].Size;

                if (tShirts[i].Size < minValue)
                    minValue = tShirts[i].Size;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[maxValue - tShirts[i].Size] == null)
                    bucket[maxValue - tShirts[i].Size] = new LinkedList<TShirt>();
                bucket[maxValue - tShirts[i].Size].AddLast(tShirts[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;
                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void BucketSortByColorAscending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
                return;

            Color maxValue = tShirts[0].Color;
            Color minValue = tShirts[0].Color;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Color > maxValue)
                    maxValue = tShirts[i].Color;
                if (tShirts[i].Color < minValue)
                    minValue = tShirts[i].Color;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[tShirts[i].Color - minValue] == null)
                    bucket[tShirts[i].Color - minValue] = new LinkedList<TShirt>();
                bucket[tShirts[i].Color - minValue].AddLast(tShirts[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;
                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void BucketSortByColorDescending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
                return;

            Color maxValue = tShirts[0].Color;
            Color minValue = tShirts[0].Color;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Color > maxValue)
                    maxValue = tShirts[i].Color;

                if (tShirts[i].Color < minValue)
                    minValue = tShirts[i].Color;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[maxValue - tShirts[i].Color] == null)
                    bucket[maxValue - tShirts[i].Color] = new LinkedList<TShirt>();
                bucket[maxValue - tShirts[i].Color].AddLast(tShirts[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;
                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void BucketSortByFabricAscending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
                return;

            Fabric maxValue = tShirts[0].Fabric;
            Fabric minValue = tShirts[0].Fabric;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Fabric > maxValue)
                    maxValue = tShirts[i].Fabric;
                if (tShirts[i].Fabric < minValue)
                    minValue = tShirts[i].Fabric;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[tShirts[i].Fabric - minValue] == null)
                    bucket[tShirts[i].Fabric - minValue] = new LinkedList<TShirt>();
                bucket[tShirts[i].Fabric - minValue].AddLast(tShirts[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;
                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void BucketSortByFabricDescending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
                return;

            Fabric maxValue = tShirts[0].Fabric;
            Fabric minValue = tShirts[0].Fabric;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Fabric > maxValue)
                    maxValue = tShirts[i].Fabric;

                if (tShirts[i].Fabric < minValue)
                    minValue = tShirts[i].Fabric;
            }

            LinkedList<TShirt>[] bucket = new LinkedList<TShirt>[maxValue - minValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[maxValue - tShirts[i].Fabric] == null)
                    bucket[maxValue - tShirts[i].Fabric] = new LinkedList<TShirt>();
                bucket[maxValue - tShirts[i].Fabric].AddLast(tShirts[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<TShirt> node = bucket[i].First;
                    while (node != null)
                    {
                        tShirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }

        public void BucketSortByBySizeThenByColorThenByFabricAscending(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
                return;

            Size maxSizeValue = tShirts[0].Size;
            Size minSizeValue = tShirts[0].Size;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Size > maxSizeValue)
                    maxSizeValue = tShirts[i].Size;
                if (tShirts[i].Size < minSizeValue)
                    minSizeValue = tShirts[i].Size;
            }

            Color maxColorValue = tShirts[0].Color;
            Color minColorValue = tShirts[0].Color;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Color > maxColorValue)
                    maxColorValue = tShirts[i].Color;
                if (tShirts[i].Color < minColorValue)
                    minColorValue = tShirts[i].Color;
            }

            Fabric maxFabricValue = tShirts[0].Fabric;
            Fabric minFabricValue = tShirts[0].Fabric;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Fabric > maxFabricValue)
                    maxFabricValue = tShirts[i].Fabric;
                if (tShirts[i].Fabric < minFabricValue)
                    minFabricValue = tShirts[i].Fabric;
            }

            LinkedList<TShirt>[,,] bucket = new LinkedList<TShirt>[maxSizeValue - minSizeValue + 1, maxColorValue - minColorValue +1, maxFabricValue - minFabricValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[tShirts[i].Size - minSizeValue, tShirts[i].Color - minColorValue, tShirts[i].Fabric - minFabricValue] == null)
                {
                    bucket[tShirts[i].Size - minSizeValue, tShirts[i].Color - minColorValue, tShirts[i].Fabric - minFabricValue] = new LinkedList<TShirt>();
                }
                bucket[tShirts[i].Size - minSizeValue, tShirts[i].Color - minColorValue, tShirts[i].Fabric - minFabricValue].AddLast(tShirts[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.GetLength(0); i++)
            {
                for (int j = 0; j < bucket.GetLength(1); j++)
                {
                    for (int m = 0; m < bucket.GetLength(2); m++)
                    {
                        if (bucket[i, j, m] != null)
                        {
                            LinkedListNode<TShirt> node = bucket[i, j, m].First;
                            while (node != null)
                            {
                                tShirts[k] = node.Value;
                                node = node.Next;
                                k++;
                            }
                        }
                    }
                }
            }
        }

        public void BucketSortBySizeThenByColorThenByFabricDescendingg(List<TShirt> tShirts)
        {
            if (tShirts == null || tShirts.Count <= 1)
                return;

            Size maxSizeValue = tShirts[0].Size;
            Size minSizeValue = tShirts[0].Size;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Size > maxSizeValue)
                    maxSizeValue = tShirts[i].Size;
                if (tShirts[i].Size < minSizeValue)
                    minSizeValue = tShirts[i].Size;
            }

            Color maxColorValue = tShirts[0].Color;
            Color minColorValue = tShirts[0].Color;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Color > maxColorValue)
                    maxColorValue = tShirts[i].Color;
                if (tShirts[i].Color < minColorValue)
                    minColorValue = tShirts[i].Color;
            }

            Fabric maxFabricValue = tShirts[0].Fabric;
            Fabric minFabricValue = tShirts[0].Fabric;

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (tShirts[i].Fabric > maxFabricValue)
                    maxFabricValue = tShirts[i].Fabric;
                if (tShirts[i].Fabric < minFabricValue)
                    minFabricValue = tShirts[i].Fabric;
            }

            LinkedList<TShirt>[,,] bucket = new LinkedList<TShirt>[maxSizeValue - minSizeValue + 1, maxColorValue - minColorValue + 1, maxFabricValue - minFabricValue + 1];

            for (int i = 0; i < tShirts.Count; i++)
            {
                if (bucket[maxSizeValue - tShirts[i].Size, maxColorValue - tShirts[i].Color, maxFabricValue - tShirts[i].Fabric] == null)
                {
                    bucket[maxSizeValue - tShirts[i].Size, maxColorValue - tShirts[i].Color, maxFabricValue - tShirts[i].Fabric] = new LinkedList<TShirt>();
                }
                bucket[maxSizeValue - tShirts[i].Size, maxColorValue - tShirts[i].Color, maxFabricValue - tShirts[i].Fabric].AddLast(tShirts[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.GetLength(0); i++)
            {
                for (int j = 0; j < bucket.GetLength(1); j++)
                {
                    for (int m = 0; m < bucket.GetLength(2); m++)
                    {
                        if (bucket[i, j, m] != null)
                        {
                            LinkedListNode<TShirt> node = bucket[i, j, m].First;
                            while (node != null)
                            {
                                tShirts[k] = node.Value;
                                node = node.Next;
                                k++;
                            }
                        }
                    }
                }
            }
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
            BucketSortByColorAscending(tShirts);
        }

        public void SortByFabricAscending(List<TShirt> tShirts)
        {
            BucketSortByFabricAscending(tShirts);
        }

        public void SortByFabricDescending(List<TShirt> tShirts)
        {
            BucketSortByFabricDescending(tShirts);
        }

        public void SortBySizeAscending(List<TShirt> tShirts)
        {
            BucketSortBySizeAscending(tShirts);
        }

        public void SortBySizeDescending(List<TShirt> tShirts)
        {
            BucketSortBySizeDescending(tShirts);
        }

        public void SortBySizeThenColorAscending(List<TShirt> tShirts)
        {
            BucketSortByBySizeThenByColorThenByFabricAscending(tShirts);
        }

        public void SortBySizeThenColorDescending(List<TShirt> tShirts)
        {
            BucketSortBySizeThenByColorThenByFabricDescendingg(tShirts);
        }

        public void SortByColorDescending(List<TShirt> tShirts)
        {
            BucketSortByColorDescending(tShirts);
        }
    }
}
