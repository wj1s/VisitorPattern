using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class HealthRatingVisitor : IVisitor
    {
        private List<int> healthRatings;
        public int HealthRating { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            ingredient.Smell();
            HealthRating = ingredient.Nutrition.HealthRating;
        }

        public List<int> VisitHealthRating(MenuItem menuItem)
        {
            Visit(menuItem);
            return healthRatings;
        }

        public void Visit(MenuItem menuItem)
        {
            healthRatings = menuItem.Ingredients.Select(i =>
                {
                    var healthRatingVisitor = this;
                    i.GetNutrition(healthRatingVisitor);
                    return healthRatingVisitor.HealthRating;
                }).ToList();
        }
    }
}