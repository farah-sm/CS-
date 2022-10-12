namespace AverageSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many scores would you like to calculate: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] scores = new int[size];

            for (int i = 0; i < scores.Length; i++)
            {
                int input;

                do
                {
                    Console.Write("Input Scores: ");
                    input = Convert.ToInt32(Console.ReadLine());

                }
                while (input < 1 || input > 5);

                scores[i] = input;
            }

            int sum = 0;
            
          for (int i = 0; i < scores.Length; i++)
            
            {

                sum += scores[i];
            }


            double average = (double) sum / scores.Length;

            Console.WriteLine($"The average number is {average}" );
               
             

        }
    }
}
