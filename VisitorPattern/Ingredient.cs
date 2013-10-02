namespace VisitorPattern
{
    public class Ingredient
    {
        private NutritionInfo Nutrition { get; set; }

        public Ingredient(NutritionInfo nutrition)
        {
            Nutrition = nutrition;
        }

        # region main action
                public void AddToPot() {}
                public void AddWater() {}
                public void AddOil() {}
                public void Smell() {}
        # endregion

        public int GetHealthRating()
        {
            Smell();
            return Nutrition.HealthRating;
        }

        public string GetProtein()
        {
            return Nutrition.Protein + " g";
        }

        public string GetCalory()
        {
            return Nutrition.Calory + " J";
        }
    }
}
