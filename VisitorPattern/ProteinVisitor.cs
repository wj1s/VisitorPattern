using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class ProteinVisitor : IVisitor
    {
        public List<string> Proteins { get; private set; }
        public string Protein { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            Protein = ingredient.Nutrition.Protein + " g";
        }

        public void Visit(MenuItem menuItem)
        {
            Proteins = menuItem.Ingredients.Select(i =>
                {
                    var proteinVisitor = this;
                    i.Accept(proteinVisitor);
                    return proteinVisitor.Protein;
                }).ToList();
        }
    }
}