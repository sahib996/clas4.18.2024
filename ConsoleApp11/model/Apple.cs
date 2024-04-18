using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.model
{
    internal class Apple:Fruit
    {
        public int VitaminA;
        public  int VitaminB;

        public Apple(decimal Price, string sort,int vitaminA,int vitaminB) : base(Price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }

        public override void Taste()
        {

            Console.WriteLine("Tastes like apple");
        }
    }
}
