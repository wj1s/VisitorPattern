namespace VisitorPattern
{
    public class ProteinVisitor
    {
        public string VisitProtein(Ingredient ingredient)
        {
            return ingredient.Nutrition.Protein + " g";
        }
    }
}