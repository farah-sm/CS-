namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] scores = { 1.7, 2.7, 3.7, 4.8, 4.9 };

            double[] scoresReverse = new double[scores.Length];


            for (int i = 0, j = scoresReverse.Length - 1; i < scores.Length; i++, j--)
            {
                scoresReverse[j] = scores[i];

            }

            for (int i = 0; i <scores.Length; i++)
            {
                Console.WriteLine(scores[i]);

            }

            Console.WriteLine();

            foreach (double score in scoresReverse)
            {
                Console.WriteLine(score);   
            }

           

        }

    }
}

