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

        public void GetNutrition(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
