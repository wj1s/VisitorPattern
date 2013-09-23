using System.Collections.Generic;
using VisitorPattern;
using Xunit;

namespace VisitorPatternTest
{
    public class MenuTest
    {
        private static readonly Ingredient flour = CreateFlour();
        private static readonly Ingredient yolk = CreateYolk();
        private static readonly MenuItem moonCake = CreateMoonCake();

        [Fact]
        public void should_calc_health_rating_Ingredient()
        {
            Assert.Equal(1, flour.GetHealthRating());
        }

        [Fact]
        public void should_calc_calories_for_Ingredient()
        {
            Assert.Equal(10, flour.GetCalories());
        }

        [Fact]
        public void should_calc_protein_for_Ingredient()
        {
            Assert.Equal(100, flour.GetProtein());
        }

        [Fact]
        public void should_calc_health_rating_for_MenuItem()
        {
            Assert.Equal(2, moonCake.GetHealthRating());
        }

        [Fact]
        public void should_calc_calories_for_MenuItem()
        {
            Assert.Equal(40, moonCake.GetCalories());
        }

        [Fact]
        public void should_calc_protein_for_MenuItem()
        {
            Assert.Equal(151, moonCake.GetProtein());
        }

        private static Ingredient CreateFlour()
        {
            var nutrition = new NutritionInfo
                {
                    HealthRating = 1, 
                    Calories = 10, 
                    Protein = 100
                };

            return new Ingredient(nutrition);
        }

        private static Ingredient CreateYolk()
        {
            var nutrition = new NutritionInfo
                {
                    HealthRating = 2, 
                    Calories = 20, 
                    Protein = 200
                };

            return new Ingredient(nutrition);
        }

        private static MenuItem CreateMoonCake()
        {
            var ingredients = new List<Ingredient> {flour, yolk};
            var menuItem = new MenuItem(ingredients, 1);
            return menuItem;
        }
    }
}
