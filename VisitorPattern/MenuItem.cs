using System.Collections.Generic;

namespace VisitorPattern
{
    public class MenuItem
    {
        private List<Ingredient> Ingredients { get; set; }

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

        public void Accept(IVisitor visitor)
        {
            Ingredients.ForEach(i => i.Accept(visitor));
            visitor.Visit(this);
        }
    }
}
