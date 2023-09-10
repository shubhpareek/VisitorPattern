namespace ClassLibrary
{
    public abstract class Visitor
    {
        public abstract void VisitCircle(Circle obj);
        public abstract void VisitRectangle(Rectangle obj);
        public abstract void VisitTriangle(Triangle obj);

    }
}
