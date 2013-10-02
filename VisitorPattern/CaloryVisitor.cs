using System.Collections.Generic;

namespace VisitorPattern
{
    public class CaloryVisitor : IVisitor
    {
        public List<string> Calories { get; private set; }
        public string Calory { get; private set; }

        public CaloryVisitor()
        {
            Calories = new List<string>();
        }

        public void Visit(Ingredient ingredient)
        {
            Calory = ingredient.Nutrition.Calory + " J";
            Calories.Add(Calory);
        }

        public void Visit(MenuItem menuItem)
        {
            Calories.Add("Cooking will double calories!!!");
        }
    }
}