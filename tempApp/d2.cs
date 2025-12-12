//this() for calling overloaded constructor, this for current instance variable
namespace A
{
    interface AW
    {
        bool isPrime(int n);
        void RangePrime(int start, int end);
    }
    class Aditya: AW
    {
        public bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public void RangePrime(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }   
    // class Parent
    // {
    //     public int value;
    //     public Parent():this(10)
    //     {
    //         Console.WriteLine("Parent()");
    //     }
    //     public Parent(int x)
    //     {
    //         this.value = x;
    //         Console.WriteLine("Parent(int x)", this.value);
    //     }
    // }
    // class Child : Parent
    // {
    //     public Child() : base()
    //     {
    //         Console.WriteLine("Child()");
    //     }
    // }
    class D2
    {
        public static void Man()
        {
            Aditya a = new Aditya();
            Console.WriteLine("Primes between 10 and 50:");
            a.RangePrime(10, 50);
        //     Console.WriteLine("Hello from Day 2!");
        //     Child t = new Child();
        //     Console.WriteLine("Value: " + t.value); // Accessing instance variable using 'this'
        }
    } 
}