﻿using StrategyPatern_T_Shirt.Interface;
using StrategyPatern_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.BusinessLogic
{
    class CreditCardPaymentStrategy : IPaymentStrategy
    {
        void IPaymentStrategy.DoPayment(TShirt tShirt)
        {
            decimal bacePrice = 0.0m;
            switch (tShirt.Fabric)
            {
                case Fabric.WOOL:
                case Fabric.COTTON:
                    bacePrice = 30.0m;
                    break;
                case Fabric.POLYESTER:
                case Fabric.RAYON:
                    bacePrice = 25.0m;
                    break;
                case Fabric.LINEN:
                case Fabric.CASHMERE:
                case Fabric.SILK:
                    bacePrice = 40.0m;
                    break;
            }

            switch (tShirt.Size)
            {
                case Size.S:
                case Size.M:
                case Size.L:
                case Size.XS:
                case Size.XL:
                case Size.XXL:
                case Size.XXXL:
                    bacePrice += bacePrice * 0.10m;
                    break;
            }
            switch (tShirt.Color)
            {
                case Color.VIOLET:
                case Color.INDIGO:
                    bacePrice += bacePrice * 0.05m;
                    break;
            }

            Console.WriteLine($"The price of your T-Shirt is {bacePrice :0.##}\u20AC");
        }
    }
}
