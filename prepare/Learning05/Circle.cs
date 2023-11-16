public class Circle : Shape {
    private double _radius;

    public Circle (string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {   
        double piValue = Math.PI;
        return piValue * (_radius * _radius);
    }
}