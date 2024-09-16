using Figures.Implementations;
using NUnit.Framework;

namespace Figures.Tests;

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Constructor_ValidSides_ShouldCreateTriangle()
        {
            double x = 3.0, y = 4.0, z = 5.0;
            
            var triangle = new Triangle(x, y, z);
            
            Assert.That(x, Is.EqualTo(triangle.X));
            Assert.That(y, Is.EqualTo(triangle.Y));
            Assert.That(z, Is.EqualTo(triangle.Z));
        }

        [Test]
        public void Constructor_InvalidSides_ShouldThrowArgumentException()
        {
            double x = 1, y = 2, z = 10;
            
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(x, y, z));
            Assert.That(ex.Message, Is.EqualTo("The sum of any two sides must be greater than the length of the third side."));
        }

        [Test]
        public void Constructor_NegativeOrZeroSide_ShouldThrowArgumentOutOfRangeException()
        {
            double x = -3.0, y = 4.0, z = 5.0;
            
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(x, y, z));
            Assert.That(ex.Message, Does.Contain("Side of triangle cannot be lesser than zero!"));
        }

        [Test]
        public void CalculateArea_ValidTriangle_ShouldReturnCorrectArea()
        {
            double x = 3.0, y = 4.0, z = 5.0;
            var triangle = new Triangle(x, y, z);
            var expectedArea = 6.0;
            
            var area = triangle.CalculateArea();
            
            Assert.That(expectedArea, Is.EqualTo(area).Within(0.00001));
        }

        [Test]
        public void CalculateArea_InvalidTriangle_ShouldThrowArgumentException()
        {
            double x = 1, y = 2, z = 10;
            
            Assert.Throws<ArgumentException>(() => _ = new Triangle(x, y, z));
        }
    }