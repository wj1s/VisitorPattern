namespace VisitorPattern
{
    public class HealthRatingVisitor
    {
        public int VisitHealthRating(Ingredient ingredient)
        {
            ingredient.Smell();
            return ingredient.Nutrition.HealthRating;
        }
    }
}