using System;
using System.Collections.Generic;


namespace Sum
{
    public class Sum
    {
        public static int SummedAll(List<int> myList)
        {
            var elements = 0;
            if (myList.Count != 0)
            {
                foreach (var item in myList)
                {
					elements += item;
					
                }
                return elements;
            }
            return 0;
        }
    }
}
