namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int dice1 = 0 , dice2 = 0;

            while (dice1 != 6 || dice2 != 6) // complete with a proper logical expression
            {

                // random numbers from 1 to 6
                dice1 = r.Next(1, 7);
                dice2 = r.Next(1, 7);

                Console.WriteLine($"Dice 1: {dice1}, Dice 2: {dice2}"); //String interpulation '$'            }
            }
        }
    }
}

