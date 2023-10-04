class Staff
{
    int staffNumber;
    string staffName;

    public Staff (string name, int number) 
    {
        staffName = name;
        staffNumber = number;
    }
    public string getName() {
        return staffName;
    }
    public int getNumber() {
        return staffNumber;
    }

}