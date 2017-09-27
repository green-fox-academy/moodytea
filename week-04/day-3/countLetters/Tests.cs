using System;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;


namespace countLetters
{
   [TestFixture]
   public class Tests
   {
        string SomeDrWhoQuote = "1'm being extremely clever up here, but there is no1 to stand around looking impressed. What'5 the p0int 1n havin9 y0u 4ll?"; 
            
	   [Test]
	   public void LetterCountIntheBeggining()
	   {
            int counted = 3;
            Dictionary<char, int> output = CountLetters.CountTheLetters(SomeDrWhoQuote);

            Assert.AreEqual(counted, output['1']);
	   }

	   [Test]
	   public void LetterCountIntheEnd()
	   {
			int counted = 5;
			Dictionary<char, int> output = CountLetters.CountTheLetters(SomeDrWhoQuote);

			Assert.AreEqual(counted, output['l']);
	   }

       [Test]
       public void CountSpecial()
       {
			int counted = 1;
			Dictionary<char, int> output = CountLetters.CountTheLetters(SomeDrWhoQuote);
			Assert.AreEqual(counted, output['?']);
       }

       [Test]
       public void CountSpaces()
       {
			int counted = 21;
			Dictionary<char, int> output = CountLetters.CountTheLetters(SomeDrWhoQuote);
			Assert.AreEqual(counted, output[' ']);
       }
   }
}
