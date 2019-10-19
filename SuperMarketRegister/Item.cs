using System;

namespace SuperMarketRegister
{
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Quantity} {Name} @ {Price:C2} = {Total:C2}";
        }

        public decimal Total => Quantity * Price;
    }
}