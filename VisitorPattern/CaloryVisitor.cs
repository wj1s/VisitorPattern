using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class CaloryVisitor : IVisitor
    {
        public string Calory { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            Calory = ingredient.Nutrition.Calory + " J";
        }

        public List<string> VisitCalory(MenuItem menuItem)
        {
            var calory = menuItem.Ingredients.Select(i =>
                {
                    var caloryVisitor = this;
                    i.GetNutrition(caloryVisitor);
                    return caloryVisitor.Calory;
                }).ToList();
            calory.Add("Cooking will double calories!!!");
            return calory;
        }
    }
}