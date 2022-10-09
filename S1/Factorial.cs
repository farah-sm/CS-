class Program
{
    static void Main(string[] args)
    {
        int n;
        // Keep prompting user for the input of a positive number
        do
        {
            Console.WriteLine("What is your number: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        while (0 > n);

        int factorial = 1;
        // count used to represent the factors in the loop
        int count = n;

        // cf is count - 1, decrement cf by 1 until cf is no longer greater than 1
     for (int cf = count - factorial; cf > factorial; cf--)
        {
            
            count = count * cf;
        }
        // print result
        Console.WriteLine($"Your Number is {count}");
    }
}
