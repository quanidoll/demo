internal class Read
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap vao du lieu: ");
        int a = Console.Read();
        Console.WriteLine("Du lieu vua nhap la " + a);
        Console.Write("Nhap vao du lieu: ");
        string str = Console.ReadLine();
        Console.WriteLine("Du lieu vua nhap la " + str);
    
    }      
}