using ConsoleApp11.model;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main()
        {
            Apple a = new Apple(1m, "Apple", 2, 3);
            Pineapple p = new Pineapple(1, "Pineapple", 4, 5);
            Orange o = new Orange(1, "Orange", 6);
            
            Fruit[] Basket = { a, p, o };   
            /*foreach (Fruit fruit in Basket) 
            {*/
                /*Apple app = fruit as Apple;
                Pineapple pine = fruit as Pineapple;
                Orange org = fruit as Orange;
*/
                /*Console.WriteLine(app.VitaminA);
                Console.WriteLine(pine.VitaminE);
                Console.WriteLine(org.VitaminC);*/
               /* if(app !=null)
                {
                    Console.WriteLine(app.VitaminA);
                }
                if(pine!=null)
                {
                    Console.WriteLine(pine.VitaminE);
                }
                if(org!=null)
                {
                    Console.WriteLine(org.VitaminC);
                }*/

                foreach(Fruit fruit in Basket)
                {

                     

                    var types = fruit.GetType().GetFields();
                    
                
                foreach(var type in types)
                    {
                    Console.WriteLine(type.GetValue(fruit));
                }
                }

                /*if(fruit is Apple app)
                {
                    Apple app = (Apple)fruit;
                    Console.WriteLine(app.VitaminA + " " + app.VitaminB);
                }
                else if(fruit is Pineapple pine ) 
                {
                    Console.WriteLine(pine.Sort+pine.VitanimE+" "+pine.VitaminD);
                }
                else if(fruit is Orange org) 
                {
                    Console.WriteLine(org.Sort+" "+org.VitaminC);
                }*/
            }
        }    
}