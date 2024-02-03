using System;

public class MyClass
{
    public static int x;

    // Regular method
    public void RegularMethod()
    {
        Console.WriteLine("This is a regular method");
        Console.WriteLine("Value of x: " + x++);
        StaticMethod();

    }

    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method"+x);
        MyClass myClass = new MyClass();

        myClass.RegularMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of MyClass
        MyClass.x = 5;

        // Calling a regular method
        
        // Calling a static method without creating an object
        MyClass.StaticMethod();
    }
}
