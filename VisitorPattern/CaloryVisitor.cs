namespace VisitorPattern
{
    public class CaloryVisitor
    {
        public string VisitCalory(Ingredient ingredient)
        {
            return ingredient.Nutrition.Calory + " J";
        }
    }
}