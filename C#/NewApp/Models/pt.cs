namespace NewApp.Models
{
    public class pt{
        public void PtBac1(float a, float b, float c)
        {
            System.Console.WriteLine("pt {0}x + {1} = 0 \n=> x={2}", a, b, c);
        }
        public void PtBac2(float d, float e, float f, double delta)
        {
            System.Console.WriteLine("pt {0}x*x + {1}x + {2} = 0\n=> delta ={3}",d ,e ,f, delta);
        }
    }
}