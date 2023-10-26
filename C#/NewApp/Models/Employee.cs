using System.Runtime.Intrinsics.Arm;

namespace NewApp.Models
{
    public class Employee{
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        public void EnterData(){
            System.Console.WriteLine("Ma nhan vien: ");
            MaNhanVien = Console.ReadLine();
            System.Console.WriteLine("Ten nhan vien: ");
            TenNhanVien = Console.ReadLine();
           
            Tuoi = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Luong: ");

           
             System.Console.WriteLine("Tuoi: ");
            try
            {
                Tuoi = Convert.ToInt16(Console.ReadLine());
                Luong = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Tuoi = 0;
                Luong = 0;
                throw;
            }
        }
        public void Display(){
                System.Console.WriteLine("{0} - {1} - {2} - {3}", MaNhanVien, TenNhanVien, Tuoi, Luong);  
        }  
    }
}