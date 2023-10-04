class PoliceCall
{
    public string type;
    public string location;
    public int time;
    List<Staff> policeID = new List<Staff>();

    public void AddPolice(Staff staff)
    {
        policeID.Add(staff);
    }
    public void PrintPolice() {
        foreach(Staff a in policeID) {
            Console.WriteLine(a.getName());
        }
    }
}