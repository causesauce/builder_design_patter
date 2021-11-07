using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.BuilderStuff
{
    public class Pizza
    {
        private List<string> _ingredients = new List<string>();

        public void Add(string ingredient)
        {
            this._ingredients.Add(ingredient);
        }

        public String ListIngredients()
        {
            string str = string.Empty;

            for(int i = 0; i < this._ingredients.Count; i++)
            {
                str += this._ingredients[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return str;
        }
    }
}
