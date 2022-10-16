using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random r = new Random();
        
        Console.Write("Number of Contestants: ");
        int numberOfConts = Convert.ToInt32(Console.ReadLine());
       
        // declare an array timings
        double[] timings = new double[numberOfConts];
        
        // generate the timings randomly
        for (int i = 0; i < timings.Length; i++)
        {
            
            // should generate numbers in the requested
            // range from 20.0 (included) to 100.0 (excluded) 
            timings[i] = 80 * r.NextDouble() + 20.0;
            
        }
       
         // find the best contestant: find the min in the array
         // assuming the min is in position 0
         int firstIndex = 0;
         double first = timings[0];

    //     // loop through the array elements (starting from position 1) 
         for (int i = 1; i < timings.Length; i++ ) // complete the for definition
         {
    //         // if the array value is smaller than the current min: updating
             if (timings[i] < first) //complete with right condition
             {
                first = timings[i];
                firstIndex = i;
                //Console.WriteLine(timings[i]);
             }
             {
              
             }
         }
     Console.WriteLine("Best timing (min) is:" +timings[firstIndex]);
        git
    }
}
