using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
            BasicStatistic.FindMax(numbers);
            BasicStatistic.FindMin(numbers);
            BasicStatistic.CalculateAverage(numbers);
            BasicStatistic.CalculateTotal(numbers);
            
            FlatArray.Combine();
            HowManyDuplicates.Run();
            MultiplicationOfTwoArray.Run();
            Separator.Run();
            TriangleOfNumbers.Run();
            TriangleStars.Run();
            VowelToUppercase.Run();
            GenerateCalendar.Run();







        }
    }
}
