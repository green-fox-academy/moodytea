using System;
using NUnit.Framework;
namespace AppleProject.AppleProjectTest
{
    [TestFixture]
    public class AppleTest
    {
        [Test]
        public void TestApple()
        {
            var ringo = new AddAppleClass();
            string apple = "apple";
            string output = AddAppleClass.GetApple();
            Assert.AreEqual(apple, output);

        }
    }
}
