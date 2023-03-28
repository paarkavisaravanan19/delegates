namespace delegates
{
    public class demo
    {
        public delegate void delegate_for_addition(int a, int b); //declaring delegates
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            demo.delegate_for_addition d1 = addition;
            d1 += subtraction; //multicasting delegates ==> can be used for many methods with single delegates
            //delegate calling method 1
            d1(20, 10);
            
            //delegate calling method 2
            d1.Invoke(60, 20);
            /*
            //will remove the method being called
            d1 -= subtraction;
            d1.Invoke(100, 60);
            +/
           /*
           //normal calling
           //addition(10,20); 
           */
            //for invokinf multiple times
            /*
            Delegate[] ar = d1.GetInvocationList();
            foreach(Delegate a in ar)
            {
                Console.WriteLine(a.DynamicInvoke(2,7));
            }
            */



        }
        public static void addition(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static void subtraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}