using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.model
{
    internal class Pineapple : Fruit

    {
     
       public  int VitaminE;
        public int VitaminD;
        public Pineapple(decimal Price, string sort,int vitaminE,int vitaminD) : base(Price, sort)
        {
            VitaminE = vitaminE;
            VitaminD = vitaminD;    
        }

        public override void Taste()
        {
            Console.WriteLine("Taste like Pineapple");
        }
    }
}
