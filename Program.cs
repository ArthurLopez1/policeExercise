using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static List<Staff> policeList = new List<Staff>();

    static List<PoliceCall> policeCalls = new List<PoliceCall>();

    static List<Report> crimeReport = new List<Report>();

    public static void Main()
    {   

        while(true)
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
                
                case 1:
                    PoliceCall();
                break;

                case 2:
                    
                break;
                
                case 3:
                    PoliceRegister();
                break;

                default:
                    System.Console.WriteLine("Invalid Choice. Please select 1 - 4");
                break;
            }
        

        }
    }

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
        while(true) {
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
                foreach (Staff a in policeList) {
                    if(a.getName() == policeAdd){
                        crime.AddPolice(a);
                    }
                }
            }else if(answer == 2) {
                break;
            }else{
                Console.WriteLine("Enter a valid number");
            }
            

            Console.WriteLine("Debug: ");
            crime.PrintPolice();
            answer = 0;
        }


        

    }
    public static void PrintPolice() {
        foreach(Staff a in policeList) {
            Console.Write("Name: " + a.getName());
            Console.WriteLine("  PoliceID: " + a.getNumber());
        }
        return;
    }

    public static void Register()
    {
        System.Console.WriteLine();
    } 
}



