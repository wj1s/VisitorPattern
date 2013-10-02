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
            var healthRatingVisitor = new HealthRatingVisitor();
            flour.Accept(healthRatingVisitor);
            Assert.Equal(1, healthRatingVisitor.HealthRating);
        }

        [Fact]
        public void should_calc_protein_for_Ingredient()
        {
            var proteinVisitor = new ProteinVisitor();
            flour.Accept(proteinVisitor);
            Assert.Equal("100 g", proteinVisitor.Protein);
        }

        [Fact]
        public void should_calc_calory_for_Ingredient()
        {
            var caloryVisitor = new CaloryVisitor();
            flour.Accept(caloryVisitor);
            Assert.Equal("10 J", caloryVisitor.Calory);
        }

        [Fact]
        public void should_calc_health_rating_for_MenuItem()
        {
            var healthRatingVisitor = new HealthRatingVisitor();
            moonCake.Accept(healthRatingVisitor);
            Assert.Equal(2, healthRatingVisitor.HealthRatings.Count);
            Assert.Contains(1, healthRatingVisitor.HealthRatings);
            Assert.Contains(2, healthRatingVisitor.HealthRatings);
        }

        [Fact]
        public void should_calc_protein_for_MenuItem()
        {
            var proteinVisitor = new ProteinVisitor();
            moonCake.Accept(proteinVisitor);
            Assert.Equal(2, proteinVisitor.Proteins.Count);
            Assert.Contains("100 g", proteinVisitor.Proteins);
            Assert.Contains("200 g", proteinVisitor.Proteins);
        }

        [Fact]
        public void should_calc_calory_for_MenuItem()
        {
            var caloryVisitor = new CaloryVisitor();
            moonCake.Accept(caloryVisitor);
            Assert.Equal(3, caloryVisitor.Calories.Count);
            Assert.Contains("10 J", caloryVisitor.Calories);
            Assert.Contains("20 J", caloryVisitor.Calories);
            Assert.Contains("Cooking will double calories!!!", caloryVisitor.Calories);
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
