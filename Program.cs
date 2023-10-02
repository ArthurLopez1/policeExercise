using System.Runtime.CompilerServices;

class Program
{
    static List<Staff> stationPolice = new List<Staff>();

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
                case 3:
                    PoliceRegister();
                break;

                case 1:
                    PoliceCall();
                break;

                case 2:
                    
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

        stationPolice.Add(staff);
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

        

    }

    public static void Register()
    {
        System.Console.WriteLine();
    } 
}

class Staff
{
    int staffNumber;
    string staffName;

    public Staff (string name, int number) 
    {
        staffName = name;
        staffNumber = number;
    }

}

class Report
{
    public int rNumber;
    int rDate;
    string rStation;
    string rDescription;

}

class PoliceCall
{
    public string type;
    public string location;
    public int time;
    List<Staff> policeID = new List<Staff>();

    public void addPoliceID(Staff staff)
    {
        policeID.Add(staff);
    }

}

