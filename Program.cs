namespace delegates
{
    public class demo
    {
        public delegate void delegate_for_addition(int a, int b); //declaring delegates
    }
        internal class Program
    {
        public int num = 10;

        static void Main(string[] args)
        {
            //demo.delegate_for_addition d1 = addition;
            //d1 += subtraction; //multicasting delegates ==> can be used for many methods with single delegates
            //delegate calling method 1
            //d1(20, 10);

            //delegate calling method 2
            //d1.Invoke(60, 20);
            /*
            //action type built in delegates
            Action<string> a1= (msg) =>  Console.WriteLine(msg);
            a1("world");
            */


            //func==> can take input and output
            Func<int, int, int, int> f1 = (a, b, c) =>
            { int result = a + b + c;
                Console.WriteLine(result);
                return result;  
            };
            Console.WriteLine(f1(10, 6, 7));

            Func<string, string, int, int, int> f2 = (a, b, c, d) =>
            {
                string result = a + b;
                Console.WriteLine($"Result in string : {result}");
                int result1= c+d;
                return result1;
            };
            Console.WriteLine(f2( "paarkavi ", " priya", 7, 10));
           
            Func<Program> s3 = () =>
            {
                Program p1 = new Program();
                return p1;
            };
            var val = s3().num;
            Console.WriteLine(val);

            
            
            List<string> l1 = new List<string>() { "paarkavi","priya","madhura"};
            Func<List<string>, List<string>> s4= (l1) =>
                {
                    l1.Sort();
                    return l1;
            };
            

            //var val1 = s4(l1);
            //Console.WriteLine(val1);
            foreach(var i in s4(l1))
            {
            Console.WriteLine(i);
            }
            


            Predicate<int> pd = (a) =>
            {
                return a > 5;
            };
            Console.WriteLine(pd(5));


            Func<int, int, bool> checker = (a, b) => { return a > b;  };
            Console.WriteLine(checker(3, 5));
            



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
    public class show
    {
        public void display()
        {
            var result = (int x, int y) =>
            {
                int total = 0;
                total = x + y;
                return total;
            };
            Console.WriteLine("result: " + result(13, 89));
       }
    }
}