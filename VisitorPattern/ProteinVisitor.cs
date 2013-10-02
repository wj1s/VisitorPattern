using System.Collections.Generic;

namespace VisitorPattern
{
    public class ProteinVisitor : IVisitor
    {
        public List<string> Proteins { get; private set; }
        public string Protein { get; private set; }

        public ProteinVisitor()
        {
            Proteins = new List<string>();
        }

        public void Visit(Ingredient ingredient)
        {
            Protein = ingredient.Nutrition.Protein + " g";
            Proteins.Add(Protein);
        }

        public void Visit(MenuItem menuItem)
        {
        }
    }
}