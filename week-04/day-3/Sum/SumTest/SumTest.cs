using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Sum.SumTest
{
    [TestFixture]
    public class SumTest
    {	
        public List<int> FirstFiveList = new List<int>();

        [Test]
		public void SumTestForEmpty()
		{
            var summed = 0;

			int output = Sum.SummedAll(FirstFiveList);
			Assert.AreEqual(summed, output);
		}

        [Test]
        public void SumTestForOneElement()
        {
            FirstFiveList.Clear();
            FirstFiveList.Add(100);
            var summed = 100;

            int output = Sum.SummedAll(FirstFiveList);
            Assert.AreEqual(summed, output);
        }

		[Test]
		public void SumTestForMoreElements()
		{
            FirstFiveList.Clear();
            int[] input = { 1,2,3,4,5 };
            FirstFiveList.AddRange(input);
			var summed = 15;

			int output = Sum.SummedAll(FirstFiveList);
			Assert.AreEqual(summed, output);
		}
    }
}
