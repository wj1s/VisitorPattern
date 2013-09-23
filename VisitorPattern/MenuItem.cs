using System.Collections.Generic;
using System.Linq;

namespace VisitorPattern
{
    public class MenuItem
    {
        private List<Ingredient> Ingredients { get; set; }
        private int CookFactor { get; set; }

        public MenuItem(List<Ingredient> ingredients, int cookFactor)
        {
            Ingredients = ingredients;
            CookFactor = cookFactor;
        }

        # region main action
                public void AddToPot() { }
                public void AddWater() { }
                public void AddOil() { }
                public void Smell() { }
                public void Taste() { }
                public void Cook() { }
        # endregion

        public int GetHealthRating()
        {
            return Ingredients.Max(i => i.GetHealthRating());
        }

        public int GetCalories()
        {
            return Ingredients.Sum(i => i.GetCalories()) + 10;
        }

        public decimal GetProtein()
        {
            return Ingredients.Sum(i => (i.GetProtein() + CookFactor)/2);
        }
    }
}
