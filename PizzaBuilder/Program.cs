using PizzaBuilder;

PizzaBuilder.PizzaBuilder pb = new PizzaBuilder.PizzaBuilder();

Pizza p1 = PizzaDirector.Margharita(pb);
Console.WriteLine(p1.ToString());

