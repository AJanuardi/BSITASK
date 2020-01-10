// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(5);
//
// Expected result
// *
// **
// ***
// ****
// *****
//
// TriangleStars(2);
//
// Expected result
// *
// **

using System;

namespace ChallengeApp
{
    public class TriangleStars
    {
        public static string Run()
        {
            Console.WriteLine("Jumlah Bintang: ");
            string jumlah = Console.ReadLine();
            int val = Convert.ToInt32(jumlah);
            int i, k ; 
            
            for (i = 1; i <= val; i++)  
            {  
            for (k = 1; k <= i; k++)  
            {    
                Console.Write("*");
            }
                Console.WriteLine("");
            }
            return jumlah;
        
        }
    }
}

