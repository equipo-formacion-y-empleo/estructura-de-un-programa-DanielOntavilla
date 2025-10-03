double CalculateTriangleArea(double baseTriangulo, double altura)
{
    return (baseTriangulo * altura) / 2;
}


double triangleBase = double.Parse(args.Length > 0 ? args[0] : "6,0");
double triangleHeight = double.Parse(args.Length > 1 ? args[1] : "4,0");


double area = CalculateTriangleArea(triangleBase, triangleHeight);
Console.WriteLine($"Área del triángulo: {area:F2}");

