public class Program{
    private static void Main(){
       float a = 10;
       if(a>=8){
        System.Console.WriteLine("Học lực giỏi");
       }
       else if(a>=6.5){
        System.Console.WriteLine("Học lực khá");
       }
       else if(a>=5){
        System.Console.WriteLine("Học lực trung bình");
       }
       else if(a>=3.5){
        System.Console.WriteLine("học lực yếu");
       }
       else {
        System.Console.WriteLine("học lực kém");
       }
    }
}