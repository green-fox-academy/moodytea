using System;

namespace String1
{
    class Program
    {
        static string ChangeXToY (string CarriedForSearch)
        {
            if (CarriedForSearch != String.Empty && CarriedForSearch.Contains("x"))
            {
                return CarriedForSearch.Replace("x", "y");
            }
            else return CarriedForSearch;
        }
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            string TextForSearch = "Xtreme extra x-factor with your x.";
           
            Console.WriteLine(ChangeXToY(TextForSearch)); 
            Console.ReadKey();
        }
    }
}
