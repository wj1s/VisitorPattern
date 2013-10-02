using System.Collections.Generic;

namespace VisitorPattern
{
    public class MenuItem
    {
        public List<Ingredient> Ingredients { get; set; }

        public MenuItem(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        # region main action
                public void AddToPot() { }
                public void AddWater() { }
                public void AddOil() { }
                public void Smell() { }
                public void Taste() { }
                public void Cook() { }
        # endregion

        public List<int> GetHealthRating()
        {
            return new HealthRatingVisitor().VisitHealthRating(this);
        }

        public List<string> GetProtein()
        {
            return new ProteinVisitor().VisitProtein(this);
        }

        public List<string> GetCalory()
        {
            return new CaloryVisitor().VisitCalory(this);
        }
    }
}
