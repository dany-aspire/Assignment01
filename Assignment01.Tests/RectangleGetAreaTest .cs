using System;
using NUnit.Framework;
using Assignment01;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleGetAreaTest
    {
        [Test]
        public void Test_GetArea()
        {
            Rectangle rect = new Rectangle(5, 6);
            int area = rect.GetArea();
            Assert.AreEqual(area, 30);
        }

    }
}
