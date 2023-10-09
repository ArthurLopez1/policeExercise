using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main()
    {   

        while(true) // Main loop
        {
            PoliceStation PS = new PoliceStation();
            System.Console.WriteLine("Welcome to Police OS");
            System.Console.WriteLine("1. Register a police call.");
            System.Console.WriteLine("2. Write a report.");
            System.Console.WriteLine("3. Register police officer.");
            System.Console.WriteLine("4. Exit");

            System.Console.WriteLine("Select option 1 - 4");
            int choice = ExceptionHandler.ReadInt();

            switch(choice)
            {
                
                case 1: // Register a police call
                    PS.PoliceCall();
                break;

                case 2: // Calls 
                    
                break;
                
                case 3:
                    PS.PoliceRegister(); // Calls PoliceRegister to register a new officer
                break;
                
                case 4: 
                    Environment.Exit(0);
                break;
                default: // Input answer out of bounds
                    System.Console.WriteLine("Invalid Choice. Please select 1 - 4");
                break;
            }
        

        }
    }

    

    

    
}



