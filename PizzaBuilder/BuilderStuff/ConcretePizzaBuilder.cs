using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.BuilderStuff
{
    public class ConcretePizzaBuilder : IBuilder
    {
        private Pizza _pizza = new Pizza();

        public ConcretePizzaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            Pizza result = this._pizza;
            this.Reset();
            return result;
        }

        public void AddBacon(string amount)
        {
            _pizza.Add($"Bacon {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddBasil(string amount)
        {
            _pizza.Add($"Basil {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddCookedHam(string amount)
        {
            _pizza.Add($"Coocked Ham {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddMozzarella(string amount)
        {
            _pizza.Add($"Mozzarella {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddOregano(string amount)
        {
            _pizza.Add($"Oregano {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddOvileOil(string amount)
        {
            _pizza.Add($"Ovile Oil {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddPepperoni(string amount)
        {
            _pizza.Add($"Pepperoni {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddPineAppleChunks(string amount)
        {
            _pizza.Add($"PineApple Chunks {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddRoastedGarlic(string amount)
        {
            _pizza.Add($"Roasted Garlic {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddTomatoes(string amount)
        {
            _pizza.Add($"Tomatoes {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void AddTomatoSauce(string amount)
        {
            _pizza.Add($"Tomato Sauce {(!String.IsNullOrEmpty(amount) ? amount : "")}");
        }

        public void SetDought(string ingredient)
        {
            _pizza.Add($"Dought {(!String.IsNullOrEmpty(ingredient) ? ingredient : "")}");
        }
    }
}
