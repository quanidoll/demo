using ClassEmployee.person;

public class sinhvien : person 
{
    public string tuoi { get; set; }
    
    public string sdt { get; set; }
    
    public void EnterData()
    {
        System.Console.WriteLine("tuoi = ");
        tuoi = Console.ReadLine();
        System.Console.WriteLine("sdt = ");
        sdt = Console.ReadLine();
        
    }
    public void Display()
    {
        System.Console.WriteLine("{0} - {1}", tuoi, sdt);
    }
}