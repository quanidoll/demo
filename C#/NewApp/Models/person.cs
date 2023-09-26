namespace MyNamespace
{
    public  public class person
    {
    public string FullName { get; set; }
    public string Address { get; set; } 
    public int Age { get; set; }
    public void EnterData()
    {
    System.Console.ReadLine("full name = ");
    FullName = Console.ReadLine();
    System.Console.WriteLine("Address =");
    Address = Console.ReadLine();
    System.Console.ReadLine("Age = ");
    Age = Console.ReadLine();
    }
    
}  
}
public void Display(){
    System.Console.ReadLine("{0} - {1} - {2}", FullName, Address, Age);
}