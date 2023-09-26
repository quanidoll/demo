
using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Person ps1 = new Person();
        Person ps2 = new Person();
        ps2.EnterData();
        ps2.Display();


    }
    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public void EnterData()
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            Id = Console.ReadLine();
            Console.WriteLine("Nhap ten sinh vien: ");
            Name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine("Ma sinh vien:" + Id);
            Console.WriteLine("Ten sinh vien: " + Name);

        }
    }

}