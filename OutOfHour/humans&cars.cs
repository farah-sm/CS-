
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Car sayaarah = new Car(2, "Toyota", "HatchBack", "Purple", 9);
        Human Khabaab = new Human("Saed", 98);
        
        
        Console.WriteLine($"My name is {Khabaab.GetName()}, I am {Khabaab.GetAge()} years old");
        Console.WriteLine($"I drive a {sayaarah.GetcarBrand()}, it is a {sayaarah.GetcarType()}. I Really like it. It is a {sayaarah.GetcarColour()} car.");
        
        
        
        
    }
    
    
    
    
    
    
    public class Car
    {
        
        
        
        private int doorNumbers;
        private string carBrand;
        private string carType;
        private string carColour;
        private int numberWheels;
        
        
        
        
        
        public Car(int dN, string cB, string cT, string cC, int nW)
        {
            doorNumbers = dN;
            carBrand = cB;
            carType = cT;
            carColour = cC;
            numberWheels = nW;
        }
        
        
   
        
    public int GetdoorNumbers()
        {
            return doorNumbers;
        }
     public string GetcarBrand()
        {
            return carBrand;
        }
     public string GetcarType()
        {
            return carType;
        }
    
     public string GetcarColour()
        {
            return carColour;
        }
    
     public int GetnumberWheels()
        {
            return numberWheels;
        }
        
        
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public class Human
    {
        private string name;
        private int age;

        // Address is exposed as a strin 
        public string address
        {
            get;
            set;
        }


        public Human(string n, int a)
        {
            name = n;
            age = a;

        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }
    }
        
}
