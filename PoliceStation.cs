class PoliceStation
{
    List<Staff> policeList = new List<Staff>();

    List<PoliceCall> policeCalls = new List<PoliceCall>();

    List<Report> crimeReport = new List<Report>();

    // Register a Police officer
    public void PoliceRegister()
    {
        System.Console.WriteLine("Write a name: ");
        string policeName = Console.ReadLine();
        System.Console.WriteLine("Type the police register number: ");
        int policeNumer = int.Parse(Console.ReadLine());

        Staff staff = new Staff(policeName, policeNumer);

        policeList.Add(staff);
    }

    public void PoliceCall()
    {
        System.Console.WriteLine("Write the type of crime: ");
        string crimeType = Console.ReadLine();
        System.Console.WriteLine("Where did the crime occured: ");
        string crimePlace = Console.ReadLine();
        System.Console.WriteLine("When did the crime occured (hhmm): ");
        int crimeTime = ExceptionHandler.ReadInt();

        PoliceCall crime = new PoliceCall();
        
        crime.type = crimeType;
        crime.location = crimePlace;
        crime.time = crimeTime;
        int answer;
        Console.WriteLine("List of police: ");
        PrintPolice();
        
        while(true) // Loop to be able to keep adding new officers to the police call
        {
            Console.WriteLine("1. Choose police to add to the police call");
            Console.WriteLine("2. Done");
            
            answer = ExceptionHandler.ReadInt();
            
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

    // Creates a report
    public void CreateReport()
    {
        System.Console.WriteLine();
    } 
    public void PrintPolice() // Prints out a list of all police officers to the user
    {
        foreach(Staff a in policeList) {
            Console.Write("Name: " + a.getName());
            Console.WriteLine("  PoliceID: " + a.getNumber());
        }
        return;
    }
}