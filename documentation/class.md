=== Class ===

Whilst Structs created instances that are stored on the stack, Classes reside in the heap.

Variables assigned to classes are only reference pointers, and do not actually store the instance of the class.

<!-- readline -->

Let's create a Student class and give it a name and a year level.

class Student
{
  public string name;
  public int yearLevel;

  public Student(string name, int yearLevel)
  {
    this.name = name;
    this.yearLevel = yearLevel;
  }
}

<!-- readline -->

Let's create a new instance of Student:

Enter student1 name:

<!-- readinput -->

Enter student1 yearLevel:

<!-- readinput -->

Student student1 = new Student({0}, {1});
