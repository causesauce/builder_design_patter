using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder.BuilderStuff
{
    public interface IBuilder
    {
        void SetDought(string ingredient);
        void AddOvileOil(string amount);
        void AddRoastedGarlic(string amount);
        void AddTomatoSauce(string  amount);
        void AddMozzarella(string amount);
        void AddTomatoes(string amount);
        void AddBasil(string amount);
        void AddCookedHam(string amount);
        void AddPineAppleChunks(string amount);
        void AddBacon(string amount);
        void AddPepperoni(string amount);
        void AddOregano(string amount);
        
    }
}
