namespace Figures.Abstractions;

/// <summary>
/// Marker abstract class for all shapes
/// </summary>
public abstract class BaseShape : IAreaCalculator
{
    /// <summary>
    /// Calculate the area of shape
    /// </summary>
    /// <returns>The area of the shape.</returns>
    public abstract double CalculateArea();
}