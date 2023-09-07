public class Program{
    private static void Main(){
        string str = "123";
        int ketQua;
        bool kiemTra = false;
        kiemTra = int.TryParse(str,out(ketQua));
        Console.WriteLine("Kết quả= "+ketQua);
    }
}