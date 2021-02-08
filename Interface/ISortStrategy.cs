using StrategyPatern_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.Interface
{
    interface ISortStrategy
    {
        void SortBySizeAscending(List<TShirt> tShirts);
        void SortBySizeDescending(List<TShirt> tShirts);
        void SortByColorAscending(List<TShirt> tShirts);
        void SortByColorDescending(List<TShirt> tShirts);
        void SortByFabricAscending(List<TShirt> tShirts);
        void SortByFabricDescending(List<TShirt> tShirts);
        void SortBySizeThenColorAscending(List<TShirt> tShirts);
        void SortBySizeThenColorDescending(List<TShirt> tShirts);
        void PrintTShirts(List<TShirt> tShirts);
    }
}
