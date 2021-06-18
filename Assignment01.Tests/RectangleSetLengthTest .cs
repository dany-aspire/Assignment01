using System;
using NUnit.Framework;
using Assignment01;

namespace Assignment01.Tests
{
    [TestFixture]
    public class RectangleSetLengthTest
    {
        [Test]
        public void Test_SetLength()
        {
            Rectangle rect = new Rectangle(5, 6);
            int res = rect.SetLength(7);
            int length = rect.GetLength();
            Assert.AreEqual(length, 7);
        }

    }
}
