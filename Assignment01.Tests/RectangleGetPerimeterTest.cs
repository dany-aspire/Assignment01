using System;
using NUnit.Framework;
using Assignment01;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleGetPerimeterTest
    {
        [Test]
        public void Test_GetPerimeter()
        {
            Rectangle rect = new Rectangle(5, 6);
            int perimeter = rect.GetPerimeter();
            Assert.AreEqual(perimeter, 22);
        }

    }
}
