using System;
using System.Collections.Generic;


// Abstract ThreeDShape class
public abstract class ThreeDShape
{
    private string shapeType;

    // Property to get the shape type
    public string ShapeType
    {
        get { return shapeType; }
    }

    // Constructor to initialize the shape type
    public ThreeDShape(string type)
    {
        shapeType = type;
    }

    // Abstract method to calculate the volume, to be implemented by derived classes
    public abstract double CalculateVolume();

    // Override the ToString method to display shape information
    public override string ToString()
    {
        return $"Type: {ShapeType}";
    }
}




// Sphere class inherits from ThreeDShape
public class Sphere : ThreeDShape 
{
    private double radius;

    // Property for the sphere's radius with validation
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value > 0)
                radius = value;
            else
                throw new ArgumentException("Radius must be positive.");
        }
    }



    // Constructor to initialize the sphere with a given radius
    public Sphere(double radius) : base("Sphere")
    {
        Radius = radius;
    }



    // Override the method to calculate the volume of a sphere
    public override double CalculateVolume()
    {
        return Math.PI * Radius * Radius * Radius * 4 / 3;
    }



    // Override the ToString method to display sphere information
    public override string ToString()
    {
        return base.ToString() + $", Radius: {Radius:F2}, Volume: {CalculateVolume():F2}";
    }
}





class Program
{
    static void Main(string[] args)
    {

        List<ThreeDShape> shapes = new List<ThreeDShape>();


        // Create instances of Sphere
        Sphere sphere1 = new Sphere(5.0);
        Sphere sphere2 = new Sphere(3.5);


        shapes.Add(sphere1);
        shapes.Add(sphere2);


        // Calculate and display volumes for all shapes
        foreach (ThreeDShape shape in shapes)
        {
            Console.WriteLine(shape);
            Console.WriteLine($"Volume: {shape.CalculateVolume():F2}");
            Console.WriteLine();
        }

    }
}
