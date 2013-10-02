namespace VisitorPattern
{
    public class HealthRatingVisitor : IVisitor
    {
        private int healthRating;

        public int VisitHealthRating(Ingredient ingredient)
        {
            Visit(ingredient);
            return healthRating;
        }

        public void Visit(Ingredient ingredient)
        {
            ingredient.Smell();
            healthRating = ingredient.Nutrition.HealthRating;
        }
    }
}