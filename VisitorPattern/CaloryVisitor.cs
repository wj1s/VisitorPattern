namespace VisitorPattern
{
    public class CaloryVisitor : IVisitor
    {
        public string Calory { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            Calory = ingredient.Nutrition.Calory + " J";
        }
    }
}