class Student : Person
{
    string program;
    int year;
    double fee;
    public Student(string name, string address, string program, int year, double fee)
    : base(name, address)
    {
        this.program = program;
        this.year = year;
        this.fee = fee;
    }
    public string getProgram()
    {
        return program;
    }
    public void setProgram(string program)
    {
        this.program = program;
    }
    public string getYear()
    {
        return program;
    }
    public void setYear(int year)
    {
        this.year = year;
    }
    public double getFee()
    {
        return fee;
    }
    public void setFee(double fee)
    {
        this.fee = fee;
    }
     public override string ToString()
    {
        return $"Student {base.ToString()} , program = {program} , year = {year} , fee = {fee}";
    }
}