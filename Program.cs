using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static List<Staff> policeList = new List<Staff>();

    static List<PoliceCall> policeCalls = new List<PoliceCall>();

    static List<Report> crimeReport = new List<Report>();

    public static void Main()
    {   

        while(true) // Main loop
        {
            System.Console.WriteLine("Welcome to Police OS");
            System.Console.WriteLine("1. Register a police call.");
            System.Console.WriteLine("2. Write a report.");
            System.Console.WriteLine("3. Register police officer.");
            System.Console.WriteLine("4. Exit");

            System.Console.WriteLine("Select option 1 - 4");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                
                case 1: // Register a police call
                    PoliceCall();
                break;

                case 2: // Calls 
                    
                break;
                
                case 3:
                    PoliceRegister(); // Calls PoliceRegister to register a new officer
                break;

                default: // Input answer out of bounds
                    System.Console.WriteLine("Invalid Choice. Please select 1 - 4");
                break;
            }
        

        }
    }

    // Register a Police officer
    public static void PoliceRegister()
    {
        System.Console.WriteLine("Write a name: ");
        string policeName = Console.ReadLine();
        System.Console.WriteLine("Type the police register number: ");
        int policeNumer = int.Parse(Console.ReadLine());

        Staff staff = new Staff(policeName, policeNumer);

        policeList.Add(staff);
    }

    public static void PoliceCall()
    {
        System.Console.WriteLine("Write the type of crime: ");
        string crimeType = Console.ReadLine();
        System.Console.WriteLine("Where did the crime occured: ");
        string crimePlace = Console.ReadLine();
        System.Console.WriteLine("When did the crime occured (hhmm): ");
        int crimeTime = int.Parse(Console.ReadLine());

        PoliceCall crime = new PoliceCall();
        
        crime.type = crimeType;
        crime.location = crimePlace;
        crime.time = crimeTime;
        int answer = 0;
        Console.WriteLine("List of police: ");
        PrintPolice();
        
        while(true) // Loop to be able to keep adding new officers to the police call
        {
            Console.WriteLine("1. Choose police to add to the police call");
            Console.WriteLine("2. Done");
            try{
                answer = int.Parse(Console.ReadLine());
            } catch (Exception e){
                Console.WriteLine("Please enter a number");
            }
            
            if(answer == 1) {
                Console.WriteLine("Enter the name of the police you want to add:");
                string policeAdd = Console.ReadLine();
                foreach (Staff a in policeList) // Search funcion for the list policeList
                {
                    if(a.getName() == policeAdd) // Adds adds the chosen police to the police report
                    {
                        crime.AddPolice(a);
                    }
                }
            }else if(answer == 2) 
            {
                break;
            }else // Answer out of bounds
            {
                Console.WriteLine("Enter a valid number");
            }
            

            Console.WriteLine("Debug: ");
            crime.PrintPolice();
            answer = 0;
        }


        

    }
    public static void PrintPolice() // Prints out a list of all police officers to the user
    {
        foreach(Staff a in policeList) {
            Console.Write("Name: " + a.getName());
            Console.WriteLine("  PoliceID: " + a.getNumber());
        }
        return;
    }

    // Creates a report
    public static void CreateReport()
    {
        System.Console.WriteLine();
    } 
}



