using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public  abstract class Product : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double Tax { get; set; }
        public abstract decimal ValueToPay();
        public override string ToString()
        {

            return $"   {Id} {Description}" +
                $"\n\tPrice......:    {Price:C2}" +
                $"\n\tTax........:    {$"{Tax:P2} ",14}";
        }
        
    }
}
