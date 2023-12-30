public class Person
{
    string name;
    string address;
    public Person(string name,string address)
    {
        this.name = name;
        this.address = address;
    }
    public virtual string getName()
    {
        return name;
    }
     public virtual string getAddress()
    {
        return address;
    }
    public void setAddress(string address)
    {
        this.address = address;
    }
     public override string ToString()
    {
        return $"Person {name} {address}";
    } 

}