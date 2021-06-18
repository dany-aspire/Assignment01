using System;
using NUnit.Framework;
using Assignment01;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleGetWidthTest
    {
        [Test]
        public void Test_GetWidth()
        {
            Rectangle rect = new Rectangle(5, 6);
            int width = rect.GetWidth();
            Assert.AreEqual(width, 6);
        }

    }
}
