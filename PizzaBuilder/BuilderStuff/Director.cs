using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.BuilderStuff
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildPepperoni()
        {
            Console.WriteLine("Preparing Pepperoni pizza...");
            _builder.SetDought("medium-thick");
            _builder.AddTomatoSauce("3 spoons");
            _builder.AddMozzarella("200 gram");
            _builder.AddOregano("");
            _builder.AddPepperoni("20 slices");
        }

        public void BuildHawaiian()
        {
            Console.WriteLine("Preparing Hawaiian pizza...");
            _builder.SetDought("thin");
            _builder.AddTomatoSauce("3 spoons");
            _builder.AddMozzarella("200 gram");
            _builder.AddCookedHam("");
            _builder.AddPineAppleChunks("");
            _builder.AddBacon("");
        }

        public void BuildMargherita()
        {
            Console.WriteLine("Preparing Margherita pizza...");
            _builder.SetDought("thin");
            _builder.AddTomatoSauce("2 spoons");
            _builder.AddMozzarella("150 grams");
            _builder.AddTomatoes("5");
            _builder.AddBasil("");
        }
    }
}
