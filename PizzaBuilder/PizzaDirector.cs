using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    static class PizzaDirector
    {
        public static Pizza Margharita(PizzaBuilder builder)
        {
            builder.ChooseSize("Big");
            builder.ChooseDough("Pizza Romana");
            builder.AddIngredient("Red souce");
            builder.AddIngredient("Oregano");
            builder.AddIngredient("Cheese");
            return builder.Build();
        }

        public static Pizza Capricciosa(PizzaBuilder builder)
        {
            builder.ChooseSize("Big");
            builder.ChooseDough("Neapolitan Pizza");
            builder.AddIngredient("Red souce");
            builder.AddIngredient("Oregano");
            builder.AddIngredient("Cheese");
            builder.AddIngredient("Ham");
            builder.AddIngredient("champignons");
            return builder.Build();
        }
    }
}
