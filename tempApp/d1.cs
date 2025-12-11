// dotnet new console -o tempApp  ; used to create a new console app
namespace A{
    class Student{
        public string name= "";
        public int age= -1;
        public long contact= 0000000000;
        public string course= "";

        public void Details(){
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Contact: " + contact);
            Console.WriteLine("Course: " + course);
        }
    }
    class D1{
        public static void Man(){
            Student Student1 = new Student();
            Student1.name = "Alice";
            Student1.age = 20;
            Student1.contact = 1234567890;
            Student1.course = "Computer Science";

            Student Student2 = new Student();
            Student2.name = "Bob";
            Student2.age = 22;
            Student2.contact = 9876543210;
            Student2.course = "Mathematics";

            Console.WriteLine("Student 1 Details:");
            Student1.Details();
            Console.WriteLine();
            Student2.Details();
        }
    }
}