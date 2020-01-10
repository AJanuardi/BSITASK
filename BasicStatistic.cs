// ========================================================
// Basic statistics - WITHOUT LINQ
// ========================================================

// int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
//
// FindMax(numbers);
//
// FindMin(numbers);
//
// CalculateAverage(numbers);
//
// CalculateTotal(numbers);

using System;

namespace ChallengeApp
{
    public class BasicStatistic
    {
        
        public static int FindMax(int[] numbers)
        {
            // Find maximum value "without" using LINQ
            int a = 0;
            int b = 0;
            for (int i = 0 ; i<numbers.Length; i++)
            {
                a = numbers[i];
                if (a > b)
                {
                    b = a;
                }
            }
            Console.WriteLine(b);
            return b;
            throw new NotImplementedException();
        }

        public static int FindMin(int[] numbers)
        {
            // Find minimum value "without" using LINQ
            int c;
            int d = numbers[0];
            for (int i = 0 ; i<numbers.Length; i++)
            {
                c = numbers[i];
                if (c < d)
                {
                    d = c;
                }
            }
            Console.WriteLine(d);
            return d;
            throw new NotImplementedException();
            
        }

        public static int CalculateAverage(int[] numbers)
        {
            // Calculate average value "without" using LINQ
            int sum = 0;
            for (int i = 0 ; i<numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            int e = (sum/numbers.Length);
            Console.WriteLine(e);
            return e;
            throw new NotImplementedException();
        }

        public static int CalculateTotal(int[] numbers)
        {
            // Calculate total value "without" using LINQ
            int f = 0;
            for (int i = 0 ; i<numbers.Length; i++)
            {
                f = f + numbers[i];
            }
            Console.WriteLine(f);
            return f;
            throw new NotImplementedException();
        }
    }
}
