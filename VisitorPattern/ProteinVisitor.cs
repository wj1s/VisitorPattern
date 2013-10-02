namespace VisitorPattern
{
    public class ProteinVisitor : IVisitor
    {
        private string protein;

        public string VisitProtein(Ingredient ingredient)
        {
            Visit(ingredient);
            return protein;
        }

        public void Visit(Ingredient ingredient)
        {
            protein = ingredient.Nutrition.Protein + " g";
        }
    }
}