using Figures.Abstractions;

namespace Figures.Implementations;

/// <summary>
/// This class representing a circle. Inherits from BaseShape class.
/// </summary>
public class Triangle : BaseShape
{
    #region variables

    /// <summary>
    /// The length of the first side of the triangle.
    /// </summary>
    public double X { get; }
    /// <summary>
    /// The length of the second side of the triangle.
    /// </summary>
    public double Y { get; }
    /// <summary>
    /// The length of the third side of the triangle.
    /// </summary>
    public double Z { get; }
    
    #endregion

    // <summary>
    /// Constructor for the Triangle class. Initializes the object with the given side lengths.
    /// Validates that the sides form a valid triangle.
    /// </summary>
    /// <param name="x">The length of the first side. Must be greater than 0.</param>
    /// <param name="y">The length of the second side. Must be greater than 0.</param>
    /// <param name="z">The length of the third side. Must be greater than 0.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when any of the sides is less than or equal to 0.</exception>
    /// <exception cref="ArgumentException">Thrown when the sum of any two sides is not greater than the third side.</exception>
    public Triangle(double x, double y, double z)
    {
        IsTriangleValid(x,y,z);

        X = x;
        Y = y;
        Z = z;
    }

    private static void IsTriangleValid(double x, double y, double z)
    {
        if (x <= 0 || y <= 0 || z <= 0)
        {
            throw new ArgumentOutOfRangeException(null, "Side of triangle cannot be lesser than zero!");
        }

        if (!(x + y > z && x + z > y && y + z > x))
        {
            throw new ArgumentException("The sum of any two sides must be greater than the length of the third side.");
        }
    }

    /// <summary>
    /// Calculates the area of the triangle using Heron's formula.
    /// </summary>
    /// <returns>The area of the triangle.</returns>
    public override double CalculateArea()
    {
        var semiPerimeter = (X + Y + Z) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - X) * (semiPerimeter - Y) * (semiPerimeter - Z));
    }
}