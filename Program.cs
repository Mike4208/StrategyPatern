using StrategyPatern_T_Shirt.BusinessLogic;
using StrategyPatern_T_Shirt.Interface;
using StrategyPatern_T_Shirt.Models;
using StrategyPatern_T_Shirt.RunProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Store.BuyTShirts();
            PerformanceTest.SortTShirts();
            PerformanceTest.CheckSpeedPerformance();
        }
    }
}
