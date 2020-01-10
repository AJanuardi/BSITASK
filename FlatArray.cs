// ========================================================
// Flatting array
// ========================================================

// int[] theFirstArray = {2, 52, 56, 12, 3};
// int[] theSecondArray = {1, 0, 65, 42};
// int[] theThirdArray = {3, 4, 6};
//
// CombineArray(theFirstArray, theSecondArray, theThirdArray)
// Expected result: {0, 1, 2, 3, 3, 4, 6, 12, 42, 52, 56, 65};

using System;

namespace ChallengeApp
{
    public class FlatArray
    {
        public static int[] Combine(params int[][] arrays)
        {
            int[] first = new int[] {2, 52, 56, 12, 3};
            int[] second = new int[] {1, 0, 65, 42};
            int[] third = new int[] {3, 4, 6};

            int count1 = first.Length;
            int count2 = second.Length;
            int count3 = third.Length;

            int[] array = new int[count1+count2+count3];
            
            int a = 0;
            int b = 0;
            int c = 0;

            int i = 0;

            while (a < count1 && b < count2 && c <count3)
            {
                if (first[a] <= second[b] && first[a] <= third[c])
                {
                    array[i++] = first[a++];
                }
                else if (second[b] <= first[a] && second[b] <= third[c])
                {
                    array[i++] = second[b++];
                }
                else if (third[c] <= first[a] && third[c] <= second[b])
                {
                    array[i++] = third[c++];
                }
            }

            if (a < count1)
            {
                for (int g = a; g<count1; g++)
                {
                    array[i++] = first[g];
                }
            }
            else if (b < count2)
            {
                for (int g = b; g<count2; g++)
                {
                    array[i++] = second[g];
                }
            }
            else if (c < count3)
            {
                for (int g = c; g<count3; g++)
                {
                    array[i++] = third[g];
                }
            }
            foreach (int p in array)
            {
                Console.Write("{0},",p);
            }
                Console.WriteLine("");
            return array;
        }
    }
}
