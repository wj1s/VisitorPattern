using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class ProteinVisitor : IVisitor
    {
        public string Protein { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            Protein = ingredient.Nutrition.Protein + " g";
        }

        public List<string> VisitProtein(MenuItem menuItem)
        {
            return menuItem.Ingredients.Select(i =>
                {
                    var proteinVisitor = this;
                    i.GetNutrition(proteinVisitor);
                    return proteinVisitor.Protein;
                }).ToList();
        }
    }
}