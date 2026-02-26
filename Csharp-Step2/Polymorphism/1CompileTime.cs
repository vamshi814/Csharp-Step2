using System;


class CompileTime
{

    public double area(double x, double y)
    {
        return x * y;   
    }
    public  double area(double a)
    {
        return 3.14 * a * a;
    }
    static void Main()
    {
        CompileTime ct = new CompileTime();
        double RectArea = ct.area(2, 4);
        Console.WriteLine(RectArea);
        double CircleArea = ct.area(5);
        Console.WriteLine(CircleArea);
    }
}