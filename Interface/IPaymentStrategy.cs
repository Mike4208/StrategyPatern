using StrategyPatern_T_Shirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.Interface
{
    interface IPaymentStrategy
    {
        void DoPayment(TShirt tShirt);
    }
}
