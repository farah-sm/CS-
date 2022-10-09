namespace Sensor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int invalid = 0, critical = 0, normal = 0, warning = 0;

            while (invalid < 3)
            {
                int temperature;
                Console.WriteLine("Insert measurement:");
                temperature = Convert.ToInt32(Console.ReadLine());

                if (temperature > 100 | temperature < 0)
                {
                    Console.WriteLine("Not Valid");
                    invalid++;
                }
                if (temperature > 30)
                {
                    Console.WriteLine("Critical");
                    critical++;
                }
                else if (temperature > 24)
                {
                    Console.WriteLine("Warning");
                    warning++;
                }
                else
                {
                    Console.WriteLine("Normal");
                    normal++;
                }

            }
            Console.WriteLine("The Sensor is Broken");
            Console.WriteLine($"Crical: {critical}, Warning {warning}, Normal {normal}");
        }
    }
}
