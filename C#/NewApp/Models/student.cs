using System.Runtime.Intrinsics.Arm;

namespace NewApp.Models
{
    public class Student
    {
        public string id { get; set; }
        public string FullName { get; set; }
        public int age { get; set; }
        public string Address { get; set; }
        public string phone { get; set; }
        public void Nhap()
        {
            try
            {
                System.Console.WriteLine("id = ");
            id = Console.ReadLine();
            System.Console.WriteLine("FullName =");
            Console.ReadLine();
            System.Console.WriteLine("Age =");
            Console.ReadLine();
            System.Console.WriteLine("Address = ");
            age = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("phone = ");
            Console.ReadLine();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Nhap sai du lieu");
                throw;
            }
        }
        public void Xuat()
        {
            System.Console.WriteLine(id + "-" + FullName +"-" + age + "-" + Address + "-" + phone);
        }
        
        
        
        
        
    }
}