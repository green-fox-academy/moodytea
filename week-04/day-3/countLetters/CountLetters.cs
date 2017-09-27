using System;
using System.Collections.Generic;

namespace countLetters
{
    public class CountLetters
    {
        public static Dictionary<char, int> CountTheLetters(string input)
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>();

            input = input.ToLower();
            char[] AtArrayPhraseNow = input.ToCharArray();

            foreach (char letter in AtArrayPhraseNow){
                if (!myDict.ContainsKey(letter))
                {
                    myDict.Add(letter,0);
                }
                myDict[letter]++;
            }
            return myDict;
			
        }
    }
}
