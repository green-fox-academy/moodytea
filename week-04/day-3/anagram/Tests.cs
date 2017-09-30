using System;
using System.Linq;
using NUnit.Framework;


namespace anagram
{
    [TestFixture]
    public class Tests
    {
        string defaultName = "Dorothy";

        [Test]
        public void WhenTheyAre()
        {
            string b = "DoorThy";
            bool output = AreTheyAnagram.SoAreTheyAnagram(defaultName, b);
			Assert.AreEqual(true, output);
        }

		[Test]
		public void WhenTheyAreNt()
		{
            string c = "Voldemort";
			bool output = AreTheyAnagram.SoAreTheyAnagram(defaultName, c);
			Assert.AreEqual(false, output);
		}
    }
}
