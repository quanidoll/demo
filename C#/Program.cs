public class Program{
    private static void Main(){
       Console.WriteLine("Nhập vào 2 số cần tính: ");
       Console.WriteLine("Nhập vào 2 số cần so sánh: ");
       int a,b;
       System.Console.WriteLine("a = ");
       a = Convert.ToInt32(Console.ReadLine());
       System.Console.WriteLine("b = ");
       b = Convert.ToInt32(Console.ReadLine());
       System.Console.WriteLine("Tổng của 2 số: {0} + {1} = {2}", a, b, a+b);
       System.Console.WriteLine("Hiệu của 2 số: {0} - {1} = {2}", a, b, a-b);
       System.Console.WriteLine("Thương của 2 số: {0} / {1} = {2}", a, b, a/b);
       System.Console.WriteLine("Tích của 2 số: {0} * {1} = {2}", a, b, a*b);
       System.Console.WriteLine("Số dư của 2 số: {0} % {1} = {2}", a, b, (a-b *(a/b)));
       if (a == b) {
        System.Console.WriteLine("Hai số bằng nhau");
       }
       if (a > b){
        System.Console.WriteLine("Số a lớn hơn số b");
       }
       if (a < b){
        System.Console.WriteLine("Số a bé hơn số b");
       }
    }
}