
using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Person[] ps = new Person[5];
        for(int i =0; i< ps.Length; i++)
        {
            Person std = new Person();
            System.Console.WriteLine("Nhap phan tu {0}: ",i);
            int a = Convert.ToInt16(Console.ReadLine());
            ps[i] = std;
            System.Console.WriteLine();
        }
    }
}

 /* Employee emp = new Employee();
 System.Console.WriteLine("nhap du lieu:");
 emp.EnterData();
 emp.Display();*/


 /* pt pt = new pt();
 int a = 10;
 int b = 20;
 int c = -b/a;
 pt.PtBac1(a,b,c);
 pt pt2 = new pt();
 int d = 30;
 int e = 40;
 int f = 50;
 int delta = e*e - 4*d*f;
 pt2.PtBac2(d,e,f,delta);