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
        public static string[] stringToConvert = File.ReadAllLines("..//..//highscorelist.txt");

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

        public void HighLister()
        {
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
            }
        }

        public void HighAdder(string highToAdd)
        {
            ListOfHighs();
            listAsIs.Add(highToAdd);
            if (highToAdd.Length.Equals(0))
            {
                Console.WriteLine("Unable to add: no task provided");
            }
            File.AppendAllText("..//..//highscorelist.txt", "\n" + highToAdd);
        }
    }
}
