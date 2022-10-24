// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        somaliMan man1 = new somaliMan();
        somaliMan man2 = new somaliMan();
        somaliMan man3 = new somaliMan();
        somaliMan man4 = new somaliMan();
        somaliMan man5 = new somaliMan();
        
        man1.Talk();
        man2.Talk();
        man3.Talk();
        man4.Talk();
        man5.Talk();
    }
    
    class somaliMan
    {
        //attributes
        private string name;
        private string name;
        private int age;

        //constructor
       
        Random rnd = new Random();
         var random = new Random();
         var list = new List<string>{ "Burco","Hargeisa","Boromo","Laas caanod"};
         int index = random.Next(list.Count);
        

          public somaliMan()
        {
            name = "abdi-" + rnd.Next(2, 298374);
            age = rnd.Next(2, 298374);
            location = list[index];
            
        }
        
        //method
        public void Talk()
        {
            Console.WriteLine($"Waryaaaahe, my name is {name} and I am {age} years old.");
            Console.Write(" I am from ");
            Console.Write(list[index]);
            Console.Write(". Where are you from?");
        }
    }
}
