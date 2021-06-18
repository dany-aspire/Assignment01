using System;
using NUnit.Framework;
using Assignment01;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleSetWidthTest
    {
        [Test]
        public void Test_SetWidth()
        {
            Rectangle rect = new Rectangle(5, 6);
            int res = rect.SetWidth(7);
            int width = rect.GetWidth();
            Assert.AreEqual(width, 7);
        }

    }
}
