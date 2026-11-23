class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();

        student1.name = "Pratik";
        student1.age = 20;
        student1.course = "Computing";

        Student student2 = new Student();

        student2.name = "Ram";
        student2.age = 21;
        student2.course = "Networking";

        Console.WriteLine("Student 1:");
        Console.WriteLine(student1.name);
        Console.WriteLine(student1.age);
        Console.WriteLine(student1.course);

        Console.WriteLine("\nStudent 2:");
        Console.WriteLine(student2.name);
        Console.WriteLine(student2.age);
        Console.WriteLine(student2.course);

        Console.WriteLine("\nCollege: " + Student.college);
    }
}