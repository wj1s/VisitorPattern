using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class MenuItem
    {
        private List<Ingredient> Ingredients { get; set; }

        public MenuItem(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        # region main action
                public void AddToPot() { }
                public void AddWater() { }
                public void AddOil() { }
                public void Smell() { }
                public void Taste() { }
                public void Cook() { }
        # endregion

        public List<int> GetHealthRating()
        {
            return Ingredients.Select(i =>
                {
                    HealthRatingVisitor healthRatingVisitor = new HealthRatingVisitor();
                    i.GetNutrition(healthRatingVisitor);
                    return healthRatingVisitor.HealthRating;
                }).ToList();
        }

        public List<string> GetProtein()
        {
            return Ingredients.Select(i =>
                {
                    ProteinVisitor proteinVisitor = new ProteinVisitor();
                    i.GetNutrition(proteinVisitor);
                    return proteinVisitor.Protein;
                }).ToList();
        }

        public List<string> GetCalory()
        {
            var calory = Ingredients.Select(i =>
                {
                    CaloryVisitor caloryVisitor = new CaloryVisitor();
                    i.GetNutrition(caloryVisitor);
                    return caloryVisitor.Calory;
                }).ToList();
            calory.Add("Cooking will double calories!!!");
            return calory;
        }
    }
}
