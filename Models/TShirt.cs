using StrategyPatern_T_Shirt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatern_T_Shirt.Models
{
    class TShirt
    {
        private IPaymentStrategy _paymantstrategy;

        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            if (paymentStrategy == null)
            {
                throw new ArgumentNullException(nameof(paymentStrategy));
            }
            this._paymantstrategy = paymentStrategy;
        }

        public void Pay()
        {
            this._paymantstrategy.DoPayment(this);
        }

        public TShirt(Color color, Size size, Fabric fabric)
        {
            this.Color = color;
            this.Size = size;
            this.Fabric = fabric;
        }

        public TShirt(Color color, Size size, Fabric fabric, IPaymentStrategy paymentStrategy ) : this(color, size, fabric) 
        {
            if (paymentStrategy == null)
            {
                throw new ArgumentNullException(nameof(paymentStrategy));
            }
            this._paymantstrategy = paymentStrategy;
        }

        public override string ToString()
        {
            return $"Size: {this.Size} | Color: {this.Color} | Fabric: {this.Fabric}";
        }
    }
}
