using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class HealthRatingVisitor : IVisitor
    {
        public List<int> HealthRatings { get; private set; }
        public int HealthRating { get; private set; }

        public void Visit(Ingredient ingredient)
        {
            ingredient.Smell();
            HealthRating = ingredient.Nutrition.HealthRating;
        }

        public void Visit(MenuItem menuItem)
        {
            HealthRatings = menuItem.Ingredients.Select(i =>
                {
                    var healthRatingVisitor = this;
                    i.Accept(healthRatingVisitor);
                    return healthRatingVisitor.HealthRating;
                }).ToList();
        }
    }
}