using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMarketRegister
{
    public class Receipt
    {
        private const int TaxPercentage = 10;

        public Receipt()
        {
            Items = new List<Item>();
        }

        private List<Item> Items { get; }


        public void AddItem(int quantity, string itemName, decimal price)
        {
            var item = new Item
            {
                Quantity = quantity,
                Name = itemName,
                Price = price,
            };

            Items.Add(item);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.AppendLine($"SubTotal = {SubTotal:C2}");
            stringBuilder.AppendLine($"Tax (10%) = {Tax:C2}");
            stringBuilder.Append($"Total = {Total:C2}");

            return stringBuilder.ToString();
        }

        public decimal Total => SubTotal + Tax;

        public decimal Tax => SubTotal / TaxPercentage;

        public decimal SubTotal => Items.Sum(i => i.Quantity * i.Price);
    }
}
