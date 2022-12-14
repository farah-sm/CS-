namespace Hospital
{
    class Program
    {
        static void ManageMedications(IPrescribable prescribable)
        {
            prescribable.PrescribeMedication("Ibuprofen");
            prescribable.PrescribeMedication("Paracetamol");
            prescribable.PrescribeMedication("Vitamin D");
            // might do other things ...

            prescribable.DeprescribeMedication("Vitamin D");
        }

        static void Main(string[] args)
        {
            // Therapy class uses an array to store the list of medications
            Therapy therapy1 = new Therapy("Flu Therapy");

            // TherapyWithList uses List<string>
            TherapyWithLists therapy2 = new TherapyWithLists("Cold Therapy");


            /* The method ManageMedications can add or delete medications to any  
               object that implements the IPrescribable interface. The  
               implementation details of how medications are stored is abstracted.
               PrescribeMedication will work regardless of how the IPrescribable 
               interface is actually implemented */

            ManageMedications(therapy1);
            ManageMedications(therapy2);

            // Can use Print() either on Therapy or TherapyWithList objects as they both implement IPrintable
            therapy1.Print();

            Console.WriteLine("SPACE");
           therapy2.Print();

        }
    }
}
