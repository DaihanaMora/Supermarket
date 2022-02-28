using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public ICollection Products { get; set; }

        //private string asistent { get; set; }

        public decimal Value { get; set; }

        public override decimal ValueToPay()
        {

            foreach (Product product in Products)
            {
                float desc = 0;
                decimal assi;
                assi = product.ValueToPay();
                desc = (float)assi * Discount;
                Value += assi - (decimal)desc;
            };
            return Value;
        }
        public override string ToString()
        {
            /*Console.WriteLine(product + "hi");  
            decimal payroll = 0;
            foreach (Product product in Products) { 
                payroll += product.ValueToPay();
                Console.WriteLine(product+"hi");
                
            }*/

            foreach (Product productDiscount in Products)
            {
                asistent += productDiscount.Description + ",";
            }

            return $"   {Id} {Description}" +
                $"\n\tProducts...:    {$"{asistent}",9}" +
                $"\n\tDiscount...:    {$"{Discount:P2}",13}" +
                $"\n\tValue......:    {$"{ValueToPay():C2}",9}";
        }
    }
}
