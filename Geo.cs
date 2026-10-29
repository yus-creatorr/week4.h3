static class Geometry
{
    public static double CalcCircleArea(double radius)
        => Math.PI * radius * radius;

    public static double CalcCirclePerimeter(double radius)
        => 2 * Math.PI * radius;

    public static double CalcRectangleArea(double length, double width)
        => length * width;

    public static double CalcRectanglePerimeter(double length, double width)
        => 2 * (length + width);

    public static double CalcTriangleArea(double baseLength, double height)
        => 0.5 * baseLength * height;

    public static double CalcTrianglePerimeter(double a, double b, double c)
        => a + b + c;
}