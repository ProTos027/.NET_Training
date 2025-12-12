//this() for calling overloaded constructor, this for current instance variable
namespace A
{
    class Parent
    {
        public int value;
        public Parent():this(10)
        {
            Console.WriteLine("Parent()");
        }
        public Parent(int x)
        {
            this.value = x;
            Console.WriteLine("Parent(int x)", this.value);
        }
    }
    class Child : Parent
    {
        public Child() : base()
        {
            Console.WriteLine("Child()");
        }
    }
    class D2
    {
        public static void Man()
        {
            Console.WriteLine("Hello from Day 2!");
            Child t = new Child();
            Console.WriteLine("Value: " + t.value); // Accessing instance variable using 'this'
        }
    }
}