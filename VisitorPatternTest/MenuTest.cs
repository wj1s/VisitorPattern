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
        public void should_calc_protein_for_Ingredient()
        {
            Assert.Equal("100 g", flour.GetProtein());
        }

        [Fact]
        public void should_calc_calory_for_Ingredient()
        {
            Assert.Equal("10 J", flour.GetCalory());
        }

        [Fact]
        public void should_calc_health_rating_for_MenuItem()
        {
            Assert.Equal(2, moonCake.GetHealthRating().Count);
            Assert.Contains(1, moonCake.GetHealthRating());
            Assert.Contains(2, moonCake.GetHealthRating());
        }

        [Fact]
        public void should_calc_protein_for_MenuItem()
        {
            Assert.Equal(2, moonCake.GetProtein().Count);
            Assert.Contains("100 g", moonCake.GetProtein());
            Assert.Contains("200 g", moonCake.GetProtein());
        }

        [Fact]
        public void should_calc_calory_for_MenuItem()
        {
            Assert.Equal(3, moonCake.GetCalory().Count);
            Assert.Contains("10 J", moonCake.GetCalory());
            Assert.Contains("20 J", moonCake.GetCalory());
            Assert.Contains("Cooking will double calories!!!", moonCake.GetCalory());
        }

        private static Ingredient CreateFlour()
        {
            var nutrition = new NutritionInfo
                {
                    HealthRating = 1, 
                    Calory = 10, 
                    Protein = 100
                };

            return new Ingredient(nutrition);
        }

        private static Ingredient CreateYolk()
        {
            var nutrition = new NutritionInfo
                {
                    HealthRating = 2, 
                    Calory = 20, 
                    Protein = 200
                };

            return new Ingredient(nutrition);
        }

        private static MenuItem CreateMoonCake()
        {
            var ingredients = new List<Ingredient> {flour, yolk};
            var menuItem = new MenuItem(ingredients);
            return menuItem;
        }
    }
}
