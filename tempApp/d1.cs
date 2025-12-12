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

    class Len
    {
        public int count= 0;
        public Len(string str){
            foreach(char c in str){
                count++;
            }
        }
        public void showLen(){
            Console.WriteLine("Length of the string is: " + count);
        }
    }
    class D1{
        public static void Man(){
            // Student Student1 = new Student();
            // Student1.name = "Alice";
            // Student1.age = 20;
            // Student1.contact = 1234567890;
            // Student1.course = "Computer Science";

            // Console.WriteLine("Student 1 Details:");
            // Student1.Details();

            Len len1 = new Len(Console.ReadLine() ?? "");
            len1.showLen();
        }
    }
}