
using System;


namespace Program_2.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            string adj, noun, natio, sheikh;
            int age;

            Console.WriteLine("Welcome to Saed-Lib. The customised game where YOU dictate\nyour own story. To play, we ask you a series of questions\nand build a story tailored to your repsonses.\n\n(HIT ENTER TO BEGIN)\n\nCaution: This game is rated 18+ \n");
            Console.ReadLine();

          
            Console.Write("What is your Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            int yearsWait = 18 - age;

            if (age > 18)
            {
                Console.Write("Random Adjective: ");
                adj = Console.ReadLine();

                Console.Write("A Friends Name: ");
                noun = Console.ReadLine();

                Console.Write("Where are you right now: ");
                natio = Console.ReadLine();

                Console.Write("Favourite Sheikh Name: ");
                sheikh = " Sheikh " + Console.ReadLine();

        
                Console.WriteLine("\nThank you for taking part in Dad Lib\nPress Enter to read your custom story.\n ");
                Console.ReadLine();

                Console.WriteLine("\n");
                Console.WriteLine($"It was a {adj} summers day.");
                Console.WriteLine($"{noun} and I were exthatic to go hiking. ");
                Console.WriteLine($"We left the {natio} for the last ever time. ");
                Console.WriteLine($"Until we stumbled by a rough sleeper, he told us he was {age} years old. I thought, 'Hold on, so am I..'");
                Console.WriteLine($"Listening to {sheikh} we carried on our journey until we saw a... (HIT ENTER TO COUNTINUE)");
                Console.ReadLine();

                Console.WriteLine("OOPS YOUR TRIAL RAN OUT... PAY £30 TO FINISH OFF YOUR STORY.");
                Console.ReadLine();

            }
            else
                Console.WriteLine($"You're too young for this game pal, just wait {yearsWait} more years");
                Console.ReadLine();

        }
    }
}
