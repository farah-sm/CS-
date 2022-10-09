using System;


namespace _1
{
    class Program
    {

        static void Main(string[] args)
        {
            char op, mult = 'x', div = '/', add = '+', sub = '-';
            int num, num2;
            string name, option;
            do
            { 
                Console.WriteLine("--------------------------");
                Console.Write("Asalmu Alaykum, welcome\nto our custom calculator. \nWhat's your name: ");
                name = Console.ReadLine();
                Console.WriteLine("--------------------------");
            
                do
                {
                    Console.Write("Choose your Operator \n(x, /, + or -): ");
                    op = Convert.ToChar(Console.ReadLine());
                }
                while (op != mult && op != add && op != sub && op != div);


                Console.Write("Input Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input Second Number: ");

                num2 = Convert.ToInt32(Console.ReadLine());



                if (op == 'x')
                    Mult(num, num2);
                else if (op == '/')
                    Div(num, num2);
                else if (op == '+')
                    Console.WriteLine($" | {num} + {num2} = {Add(num, num2)} |");
                else
                    Subt(num, num2);



                Console.WriteLine("\n\n--------------------------");
                Console.WriteLine($"Thank you for visiting our calculator {name}");
                Console.WriteLine("----------------------------\n");
                

                Console.Write("Type yes to countinue: ");
                option = Console.ReadLine();
                
            }
            while (option == "yes" || option == "Yes" || option == "YES");

        }

        // Find out more about return (Add & Mult methods)
        public static int Add(int num1, int num2) 
        {
            int answ = num1 + num2;
            return answ;
        }

        public static void Mult(int num1, int num2)
        {
            int answ = num1 * num2;
            Console.Write(" ____________ \n");
            Console.Write("|            |");
            Console.WriteLine($" \n| {num1} x {num2} = {answ}  |");
            Console.Write("|____________|");
        }

        public static void Subt(int num1, int num2)
        {
            int answ = num1 - num2;
            Console.Write(" ____________ \n");
            Console.Write("|            |");
            Console.WriteLine($" \n| {num1} - {num2} = {answ}  |");
            Console.Write("|____________|");
        }

        public static void Div(int num1, int num2)
        {
            int answ = num1 / num2;
            Console.Write(" ____________ \n");
            Console.Write("|            |");
            Console.WriteLine($" \n| {num1} / {num2} = {answ}  |");
            Console.Write("|____________|");
        }

        

    }
}
