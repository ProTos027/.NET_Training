namespace A{
    delegate int DG1(int a, char op, int b);
    // class Dgate{
    //     public delegate void DG1();
    // } 
    class D3{
        // public void display(){
        //     Console.WriteLine("Hello");
        // }
        public static int Compute(int a, char op, int b)
        {
            switch (op)
            {
                case '+':
                    return a + b;

                case '-':
                    return a - b;

                case '*':
                    return a * b;

                default:
                    throw new InvalidOperationException("Invalid Operator");
            }
        }
        public static void Man(){
            DG1 d= D3.Compute;
             Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operator (+, -, *): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + d(a, op, b));
        }
    }
}