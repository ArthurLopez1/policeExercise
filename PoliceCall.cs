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