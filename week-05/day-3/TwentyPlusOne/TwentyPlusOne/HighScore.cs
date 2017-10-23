using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    
    class HighScore
    {
        public static List<string> listAsIs = new List<string>() { };
        public static string[] stringToConvert = File.ReadAllLines(@"c:\Users\doa\moodytea\week-05\day-3\TwentyPlusOne\TwentyPlusOne\highscorelist.txt");
        

        public static List<string> ListOfHighs()
        {
            try
            {
                foreach (string s in stringToConvert)
                {
                    listAsIs.Add(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("conversion error:" + ex);
            }

            return listAsIs;

        }

        public static void HighLister()
        {
            listAsIs = new List<string>() { };
            ListOfHighs();
            if (listAsIs.Count.Equals(0))
            {
                Console.WriteLine("No highscore found.");
            }
            else
            {
                int i = 1;
                foreach (string highs in listAsIs)
                {
                    Console.WriteLine((i) + " - " + highs);
                    i++;
                }
                Console.WriteLine("And the new score of: " + Game.nameAndScore);
            }
        }

        public static void HighAdder(string highToAdd)
        {
            ListOfHighs();
            if (highToAdd.Length.Equals(0))
            {
                Console.WriteLine("Unable to add: no highscore provided");
            }
            else
            {
                listAsIs.Add(highToAdd);
                File.AppendAllText(@"c:\Users\doa\moodytea\week-05\day-3\TwentyPlusOne\TwentyPlusOne\highscorelist.txt", "\n" + highToAdd); 
            }
        }
    }
}
