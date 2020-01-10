// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(4);
//
// Expected result
// 1
// 12
// 123
// 1234
//
// TriangleStars(2);
//
// Expected result
// 1
// 12

using System;

namespace ChallengeApp
{
    public class TriangleOfNumbers
    {
        public static string Run()
        {
            Console.WriteLine("Jumlah Angka: ");
            string jumlah = Console.ReadLine();
            int val = Convert.ToInt32(jumlah);
            int i, k ; 
            
            for (i = 1; i <= val; i++)  
            {  
            for (k = 1; k <= i; k++)  
            {    
                Console.Write(k);
            }
                Console.WriteLine("");
            }
            return jumlah;
}
}
}