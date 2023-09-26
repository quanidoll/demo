namespace NewApp.Models
{
    public class Employee{
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public string Luong { get; set; }
        public void EnterData(){
            System.Console.ReadLine("Ma nhan vien: ");
            MaNhanVien = Console.ReadLine();
            System.Console.ReadLine("Ten nhan vien: ");
            TenNhanVien = Console.ReadLine();
            System.Console.ReadLine("Tuoi: ");
            Tuoi = Console.ReadLine();
            System.Console.ReadLine("Luong: ");
            Luong = Console.ReadLine();
        }
        public void Display(){
                System.Console.ReadLine("{0} - {1} - {2} - {3}", MaNhanVien, TenNhanVien, Tuoi, Luong);  
        }  
    }
}