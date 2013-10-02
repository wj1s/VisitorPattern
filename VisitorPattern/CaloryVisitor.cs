namespace VisitorPattern
{
    public class CaloryVisitor : IVisitor
    {
        private string calory;

        public string VisitCalory(Ingredient ingredient)
        {
            Visit(ingredient);
            return calory;
        }

        public void Visit(Ingredient ingredient)
        {
            calory = ingredient.Nutrition.Calory + " J";
        }
    }
}