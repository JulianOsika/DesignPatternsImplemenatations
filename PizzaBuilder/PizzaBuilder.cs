using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        public PizzaBuilder() { }

        private Pizza? _pizza = new Pizza();

        public void ChooseSize(string size) => _pizza.Size = size;

        public void ChooseDough(string dough)
        {
            _pizza.DoughType = dough;
        }

        public void AddIngredient(string ingredient)
        {
            _pizza.ingredients.Add(ingredient);
        }

        public Pizza Build()
        {
            return _pizza;
        }

    }
}
