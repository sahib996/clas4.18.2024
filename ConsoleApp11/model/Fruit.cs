using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.model
{
    internal abstract class Fruit
    {
       public decimal Price;
       public string Sort;
        public Fruit(decimal price, string sort)
        {
            Price = price;
            Sort = sort;

        }
        public abstract void Taste();

        





    }
}
