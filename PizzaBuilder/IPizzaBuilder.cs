using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    interface IPizzaBuilder
    {
        public void ChooseSize(string size);
        public void ChooseDough(string dough);
        public void AddIngredient( string ingredient);
        public Pizza Build();
    }
}
