using Figures.Abstractions;

namespace Figures.Implementations;

/// <summary>
/// This class representing a circle. Inherits from BaseShape class.
/// </summary>
public class Circle : BaseShape, IAreaCalculator
{
    /// <summary>
    /// Constructor for the Circle class. Initializes the object with the given radius.
    /// Validates the radius to ensure it meets the required conditions.
    /// </summary>
    /// <param name="radius">The radius of the circle. Must be greater than 0.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the radius is less than or equal to 0.</exception>
    private double Radius { get; }

    public Circle(double radius)
    {
        IsCircleValid(radius);
        
        Radius = radius;
    }
    
    private static void IsCircleValid(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), "radius cannot be lesser than 0!");
        }
    }

    /// <summary>
    /// Calculates the area of the circle using the formula pi * r^2.
    /// </summary>
    /// <returns>The area of the circle.</returns>
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}