using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public double Quantity { get; set; }
        public override decimal ValueToPay()
        {
            decimal QuantityTotal = Price * (decimal)Quantity;
            return (QuantityTotal * (decimal)Tax) + QuantityTotal;
        }
        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tMeasurement: {$"{Measurement}"}" +
                $"\n\tQantity....:    {$"{Quantity:N2}",11}" +
                $"\n\tPrice......:    {$"{Price:C2}"}" +
                $"\n\tTax........:    {$"{Tax:P2} ",14}"+
                $"\n\tValue......: {$"{ValueToPay():C2}",14}";
        }
    }
}
