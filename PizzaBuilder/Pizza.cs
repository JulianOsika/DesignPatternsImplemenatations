using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public class Pizza
    {
        public string Size { get; set; }
        public string DoughType { get; set; }
        public List<string> ingredients = new List<string>();

        public Pizza() { }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            foreach (string ingredient in this.ingredients)
                output.Append($" - {ingredient.ToString()}" + "\n");
            return "Your pizza: " + "\n" +
                    "Size: " + this.DoughType + "\n" +
                    "Type of pizza dough: " + this.DoughType + "\n" +
                    "Ingredients: " + "\n" + output.ToString();
        }
    }
}
