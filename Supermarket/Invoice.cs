using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Invoice : IPay
    {
        private List<Product> _products = new List<Product>();
        public Invoice() { }
        public void AddProduct(Product products) { _products.Add(products); }
        public decimal ValueToPay()
        {
            decimal totalProducts = 0;
            foreach (Product product in _products)
            {
                totalProducts += product.ValueToPay();
            }
            return totalProducts;
        }
        public override string ToString()
        {

            foreach (Product product in _products)
            { 
                Console.WriteLine(product.ToString());

            }

            return $"                     =============="
                +$"\n\tTOTAL: {$"{ValueToPay():C2}",20}";    
        }
    }
}
