using System;
using NUnit.Framework;
using Assignment01;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleGetLengthTest
    {
        [Test]
        public void Test_GetLength()
        {
            Rectangle rect = new Rectangle(5, 6);
            int length = rect.GetLength();
            Assert.AreEqual(length, 5);
        }

    }
}
