namespace VisitorPattern
{
    public class Ingredient
    {
        private NutritionInfo Nutrition { get; set; }

        public Ingredient(NutritionInfo nutrition)
        {
            Nutrition = nutrition;
        }

        public int GetHealthRating()
        {
            return Nutrition.HealthRating;
        }

        public int GetCalories()
        {
            return Nutrition.Calories;
        }

        public int GetProtein()
        {
            return Nutrition.Protein;
        }
    }
}
