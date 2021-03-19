using System;

namespace AssignCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testChilds = { 3, 2, 1, 1, 1, 4, 5, 3, 2, 1, 3 };
            int[] testCookies = { 3, 3, 3, 3, 3, 3, 3, 5, 6, 6, 2, 3, 4, 2 };
            int result = AssignCookies(testChilds, testCookies);
            Console.WriteLine(result);
        }

        public static int AssignCookies(int[] childGreediness, int[] cookieSizes)
        {
	    Array.Sort(childGreediness);
	    Array.Sort(cookieSizes);
	    
            int cookiesAssigned = 0;
            int i = 0;
	    int j = 0;
		
            while((i < childGreediness.Length) && (j < cookieSizes.Length))
	    {
		if(cookieSizes[j] >= childGreediness[i])
		{
		    cookiesAssigned++;
		    i++;
		    j++;
		}
		else
		{
		    j++;
		}
            }	

            return cookiesAssigned;
        }
    }	
}
    
