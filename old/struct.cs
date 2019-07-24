using System;
using System.ComponentModel;

class Program
{
  struct Location
  {
    public int x, y;
    public Location(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
  }

  class Student
  {
    public string name;
    public int grade;
    public Student(string name, int grade)
    {
      this.name = name;
      this.grade = grade;
    }
  }

  static void Main(string[] args)
  {
    Console.WriteLine("== Differences between Struct and Class ==\n");

    Console.WriteLine("=== Struct ====\n\n");

    Console.WriteLine("Let's create a struct, called Location");
    Console.WriteLine("Location has 2 public integers: x and y\n");
    Console.WriteLine("Let's create our first Location instance:\n");
    
    Console.WriteLine("Location location1 = new Location(25, 30);\n");

    Location location1 = new Location(25, 30);

    Console.WriteLine("location1 has the following properties:");
    Console.WriteLine("location1.x = {0}\nlocation1.y = {1}\n", location1.x, location1.y);

    Console.WriteLine("Let's create another location object based on location1\n");
    Console.WriteLine("Location location2 = location1\n");

    Location location2 = location1;

    Console.WriteLine("location2 has the following values:");
    Console.WriteLine("location2.x = {0}\nlocation2.y = {1}\n", location2.x, location2.y);

    Console.WriteLine("Let's change location2's x and y values:");
    Console.WriteLine("location2.x = 10\nlocation2.y = 13\n");

    location2.x = 10;
    location2.y = 13;

    Console.WriteLine("location2 now has the following values:");
    Console.WriteLine("location2.x = {0}\nlocation2.y = {1}\n\n", location2.x, location2.y);

    Console.WriteLine("location1 now has the following values:");
    Console.WriteLine("location1.x = {0}\nlocation1.y = {1}\n\n", location1.x, location1.y);

    Console.WriteLine("As you can see, location1 retained it's own values, whilst only location2's values were effected by the update\n\n\n");

    Console.WriteLine("=== Class ===\n\n");

    Console.WriteLine("Classes behave a bit differently in C#");
    Console.WriteLine("Let's create a class called Student");
    Console.WriteLine("Student has 2 public variables. name (string) and grade (integer)\n");

    Console.WriteLine("Let's create our first Student instance\n");

    Console.WriteLine("Student student1 = new Student(\"Bethany Johnston\", 12);\n");

    Student student1 = new Student("Bethany Johnston", 12);

    Console.WriteLine("student1 has the following properties:");
    Console.WriteLine("student1.name = {0}\nstudent1.grade = {1}\n", student1.name, student1.grade);

    Console.WriteLine("Let's create another student based off of student1\n");
    Console.WriteLine("Student student2 = student1\n");

    Student student2 = student1;

    Console.WriteLine("student2 has the following properties:");
    Console.WriteLine("student2.name = {0}\nstudent2.grade = {1}\n", student2.name, student2.grade);

    Console.WriteLine("Let's change student2's name and grade properties:");

    Console.WriteLine("student2.name = \"Adam\";\nstudent2.grade = 10;\n");
    
    student2.name = "Adam";
    student2.grade = 10;

    Console.WriteLine("student2 now has the following values:");
    Console.WriteLine("student2.name = {0}\nstudent2.grade = {1}\n", student2.name, student2.grade);

    Console.WriteLine("However, as you can see, student1 has been updated as well");
    Console.WriteLine("student1.name = {0}\nstudent1.grade = {1}\n", student1.name, student1.grade);
    
    Console.WriteLine("Because classes are a reference type, they only contain a pointer to the location in the heap where the class is stored. Therefore, assigning another variable to the original only copies that reference point. Therefore, both variables will be affecting the same object in memory\n");

    Console.WriteLine("However, structs are created as unique objects in the application's Stack, therefore, modifications made to one struct, do not affect the others.");

  }
}
    
