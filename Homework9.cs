namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student stu1 = new Student(111, "Alice");
        Student stu2 = new Student(222, "Bob");
        Student stu3 = new Student(333, "Cathy");
        Student stu4 = new Student(444, "David");

            Dictionary<string, double> gradebook = new Dictionary<string, double>();
            gradebook.Add("Alice", 4.0);
            gradebook.Add("Bob",3.6);
            gradebook.Add("Cathy", 2.5);
            gradebook.Add("David", 1.8);

            if(!gradebook.ContainsKey("Tom")){
                gradebook.Add("Tom", 3.3);
            }
            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"\nAverage GPA:{averageGPA}");
            
            foreach(Student stu in Student.studentList){
                if(gradebook.ContainsKey(stu.StudentName) && gradebook[stu.StudentName] > averageGPA){
                    stu.PrintInfo();
                }
        }
    }
    class Student{
        private int studentID;
        private string studentName;
        public static List<Student> studentList = new List<Student>();

        public string StudentName{
            get {return studentName;}
        }

        public Student(int id, string name ){
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }
        public void PrintInfo(){
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    }
}
