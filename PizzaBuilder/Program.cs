using PizzaBuilder.BuilderStuff;
using System;

namespace PizzaBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcretePizzaBuilder();
            director.Builder = builder;

            director.BuildPepperoni();
            Console.WriteLine(builder.GetPizza().ListIngredients());

            director.BuildMargherita();
            Console.WriteLine(builder.GetPizza().ListIngredients());

            director.BuildHawaiian();
            Console.WriteLine(builder.GetPizza().ListIngredients());

            Console.WriteLine("Building a custom pizza without director...");
            builder.SetDought("thick");
            builder.AddBacon("a lot");
            builder.AddTomatoSauce("a lot lot lot lot");
            builder.AddMozzarella("very much");
            builder.AddOregano("a lot");
            builder.AddRoastedGarlic("little");
            Console.WriteLine(builder.GetPizza().ListIngredients());

        }
    }
}
