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

        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in Products)
            {
                payroll += product.ValueToPay();
            };            
            return payroll - (payroll * (decimal)Discount);
        }
        public override string ToString()
        {
            List<string> products = new List<string>();

            foreach (Product product in Products) 
            {
                products.Add(product.Description + ",");
            }

            return $"   {Id} {Description}" +
                $"\n\tProducts...:    {$"{string.Join(" ", products.ToArray())}",9}" +
                $"\n\tDiscount...:    {$"{Discount:P2}",13}" +
                $"\n\tValue......:    {$"{ValueToPay():C2}",9}";
        }
    }
}
