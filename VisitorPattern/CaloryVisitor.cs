using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class CaloryVisitor : IVisitor
    {
        private List<string> calories;
        public string Calory { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            Calory = ingredient.Nutrition.Calory + " J";
        }

        public List<string> VisitCalory(MenuItem menuItem)
        {
            Visit(menuItem);
            return calories;
        }

        public void Visit(MenuItem menuItem)
        {
            calories = menuItem.Ingredients.Select(i =>
                {
                    var caloryVisitor = this;
                    i.GetNutrition(caloryVisitor);
                    return caloryVisitor.Calory;
                }).ToList();
            calories.Add("Cooking will double calories!!!");
        }
    }
}