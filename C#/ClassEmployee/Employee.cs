
public class Employee
{
    public string MaNv { get; set; }
    public string TenNv { get; set; }
    public int tuoi { get; set; }
    public double luong { get; set; }
    public void EnterData()
    {
        Console.Write("Nhap ma nhan vien: ");
        MaNv = Console.ReadLine();
        Console.Write("Nhap ten nhan vien: ");
        TenNv = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        tuoi = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap luong: ");
        luong = Convert.ToDouble(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine("Ma nhan vien: " + MaNv);
        Console.WriteLine("Ten nhan vien: " + TenNv);
        Console.WriteLine("Tuoi: " + tuoi);
        Console.WriteLine("Luong: " + luong);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EnterData();
            employee.Display();
        }
    }
}