namespace VisitorPattern
{
    public class Ingredient
    {
        public NutritionInfo Nutrition { get; set; }

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
            return new HealthRatingVisitor().VisitHealthRating(this);
        }

        public string GetProtein()
        {
            return new ProteinVisitor().VisitProtein(this);
        }

        public string GetCalory()
        {
            return new CaloryVisitor().VisitCalory(this);
        }
    }
}
