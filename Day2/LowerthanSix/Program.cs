namespace LowerthanSix;
public class Program
{
    public static void Main() { }
}    

public class Student
{
    //public int Id { get; set; }
    // Only get would mean its readonly
    private int _value;
    public int Id
    {
        get { return _value; }
        set { _value = value; }
    }
    //public int MyProperty { get; set; }

}

internal class Something
{
    internal void SomeFunction()
    {

    }
}