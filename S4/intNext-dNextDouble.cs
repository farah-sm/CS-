using System;

namespace Week_4
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //THE DIFFERENCE BETWEEN NEXTDOUBLE & INT NEXT!
            Random r = new Random();

            // Returns:
            //     A double-precision floating point number that is greater than or equal to 0.0,
            //     and less than 1.0.
            double number = r.NextDouble();


            //
            // Summary:
            //     Returns a random integer that is within a specified range.
            //
            // Parameters:
            //   minValue:
            //     The inclusive lower bound of the random number returned.
            //
            //   maxValue:
            //     The exclusive upper bound of the random number returned. maxValue must be greater
            //     than or equal to minValue.
            //
            // Returns:
            //     A 32-bit signed integer greater than or equal to minValue and less than maxValue;
            //     that is, the range of return values includes minValue but not maxValue. If minValue
            //     equals maxValue, minValue is returned.
            //
            // Exceptions:
            //   T:System.ArgumentOutOfRangeException:
            //     minValue is greater than maxValue.
            int numbers = r.Next(1, 7);






        }
    }
}
