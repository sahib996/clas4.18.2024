using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.model
{
    internal class Orange : Fruit
    {
       public int VitaminC;
        public Orange(decimal Price, string sort,int vitaminC) : base(Price, sort)
        {
            VitaminC = vitaminC;
        }

        public override void Taste()
        {
            Console.WriteLine("Taste like orange");
        }
    }
}
