using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class CaloryVisitor : IVisitor
    {
        public List<string> Calories { get; private set; }
        public string Calory { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            Calory = ingredient.Nutrition.Calory + " J";
        }

        public void Visit(MenuItem menuItem)
        {
            Calories = menuItem.Ingredients.Select(i =>
                {
                    var caloryVisitor = this;
                    i.Accept(caloryVisitor);
                    return caloryVisitor.Calory;
                }).ToList();
            Calories.Add("Cooking will double calories!!!");
        }
    }
}