namespace VisitorPattern
{
    public class ProteinVisitor : IVisitor
    {
        public string Protein { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            Protein = ingredient.Nutrition.Protein + " g";
        }
    }
}