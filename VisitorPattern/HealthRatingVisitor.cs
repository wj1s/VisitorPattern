using System.Collections.Generic;

namespace VisitorPattern
{
    public class HealthRatingVisitor : IVisitor
    {
        public List<int> HealthRatings { get; private set; }
        public int HealthRating { get; private set; }

        public HealthRatingVisitor()
        {
            HealthRatings = new List<int>();
        }

        public void Visit(Ingredient ingredient)
        {
            ingredient.Smell();
            HealthRating = ingredient.Nutrition.HealthRating;
            HealthRatings.Add(HealthRating);
        }

        public void Visit(MenuItem menuItem)
        {
        }
    }
}