namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(Ingredient ingredient);
        void Visit(MenuItem menuItem);
    }
}