// ========================================================
// Multiplication of two arrays
// ========================================================

// int[] firstArray = {1, 3, -5, 4};
// int[] secondArray = {1, 4, -5, -2};
//
// MultiplyArray(firstArray, secondArray)
//
// Expected result { 1, 12, 25, -8 }
using System;

namespace ChallengeApp
{
    public class MultiplicationOfTwoArray
    {
        public static int[] Run()
        {
        
        int[] array = new int[4];
        int[] first = {1, 3, -5, 4};
        int[] second = {1, 4, -5, -2};

        for (int i = 0; i < 4; i++)
        {
            array[i] = first[i]*second[i];
        }
        foreach (int p in array)
        {
            Console.Write("{0} ", p);
        }
            Console.WriteLine("");
        return array;
        }
    }
}
