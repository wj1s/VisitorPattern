namespace VisitorPattern
{
    public class HealthRatingVisitor : IVisitor
    {
        public int HealthRating { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            ingredient.Smell();
            HealthRating = ingredient.Nutrition.HealthRating;
        }
    }
}