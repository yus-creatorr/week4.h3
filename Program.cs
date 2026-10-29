Cache<string>.Add("name", "Ali");
        Console.WriteLine(Cache<string>.Get("name"));

        Cache<int>.Add("age", 20);
        Console.WriteLine(Cache<int>.Get("age"));

        Cache<string>.Remove("name");


         Console.WriteLine(Geometry.CalcCircleArea(5));
        Console.WriteLine(Geometry.CalcRectangleArea(4, 3));
        Console.WriteLine(Geometry.CalcTriangleArea(6, 2));

        Console.WriteLine(Calculator.Add(10, 5));
        Console.WriteLine(Calculator.Subtract(10, 5));
        Console.WriteLine(Calculator.Multiply(10, 5));
        Console.WriteLine(Calculator.Divide(10, 5));

       