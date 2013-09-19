using System.Collections.Generic;
using VisitorPattern;
using Xunit;

namespace VisitorPatternTest
{
    public class MenuTest
    {
        private static Ingredient flour = CreateFlour();
        private static Ingredient yolk = CreateYolk();
        private MenuItem moonCake = CreateMoonCake(flour, yolk);

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
            Assert.Equal(60, moonCake.GetCalories());
        }

        [Fact]
        public void should_calc_protein_for_MenuItem()
        {
            Assert.Equal(300, moonCake.GetProtein());
        }

        private static Ingredient CreateFlour()
        {
            var nutrition = new NutritionInfo();
            nutrition.HealthRating = 1;
            nutrition.Calories = 10;
            nutrition.Protein = 100;
            var flour = new Ingredient(nutrition);

            return flour;
        }

        private static Ingredient CreateYolk()
        {
            var nutrition = new NutritionInfo();
            nutrition.HealthRating = 2;
            nutrition.Calories = 20;
            nutrition.Protein = 200;
            var yolk = new Ingredient(nutrition);

            return yolk;
        }

        private static MenuItem CreateMoonCake(Ingredient flour, Ingredient yolk)
        {
            var ingredients = new List<Ingredient> {flour, yolk};
            var menuItem = new MenuItem(ingredients);
            return menuItem;
        }
    }
}
