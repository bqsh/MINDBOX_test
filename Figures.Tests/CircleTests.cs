using Figures.Implementations;
using NUnit.Framework;

namespace Figures.Tests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void Constructor_ValidRadius_ShouldCreateCircle()
    {
        var radius = 5.0;

        var circle = new Circle(radius);

        Assert.That(radius, Is.EqualTo(circle.Radius));
    }

    [Test]
    public void Constructor_NegativeOrZeroRadius_ShouldThrowArgumentOutOfRangeException()
    {
        var radius = -1.0;

        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _ = new Circle(radius));
        Assert.That(ex?.Message, Does.Contain("radius cannot be lesser than 0!"));
    }

    [Test]
    public void CalculateArea_ValidCircle_ShouldReturnCorrectArea()
    {
        var radius = 3.0;
        var circle = new Circle(radius);
        var expectedArea = Math.PI * Math.Pow(radius, 2);

        var area = circle.CalculateArea();

        Assert.That(expectedArea, Is.EqualTo(area).Within(0.00001));
    }
}