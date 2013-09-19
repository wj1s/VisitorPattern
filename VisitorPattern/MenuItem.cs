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

        public int GetHealthRating()
        {
            return Ingredients.Max(i => i.GetHealthRating());
        }

        public int GetCalories()
        {
            return Ingredients.Sum(i => i.GetCalories()) * 2;
        }

        public int GetProtein()
        {
            return Ingredients.Sum(i => i.GetProtein());
        }
    }
}
