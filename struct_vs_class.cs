using System;

namespace App
{
  class Menu
  {

    Location location1 = new Location(0, 0);

    void Continue()
    {
      Console.WriteLine("\nPress any key to conitnue...");
      Console.ReadKey(true);
      Console.Clear();
    }

    public void Struct() {
      Console.Clear();
      Console.WriteLine("== Class vs Structs ==\n");
      Console.WriteLine("Welcome! Let's discover the difference between a Class and a Struct in C#!");

      this.Continue();

      Console.WriteLine("First, let's create a Struct. We'll call it Location:\n");

      Console.WriteLine("Struct Location\n{\n  int x, y;\n\n  public Location(int x, int y)\n  {\n    this.x = x;\n    this.y = y;\n  }\n}");

      this.Continue();

      Console.WriteLine("Location has 2 public integers: x and y\n");
      Console.Write("Enter the x value for location1: ");
      location1.x = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the y value for location1: ");
      location1.y = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("\nLocation location1 = new Location({0}, {1});\n", location1.x, location1.y);

      this.Continue();

      Console.WriteLine("location1 has the following properties:");
      Console.WriteLine("x = {0}\ny = {1}", location1.x, location1.y);

      this.Continue();

      Console.WriteLine("Let's create another location based on location1\n");
      Console.WriteLine("Location location2 = location1\n");

      Location location2 = location1;

      Console.WriteLine("location2 has the following properties:");
      Console.WriteLine("x = {0}\ny = {1}", location2.x, location2.y);

      this.Continue();

      Console.WriteLine("Let's change location2's properties\n");

      Console.Write("Enter the new x value for location2: ");
      location2.x = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the new y value for location2: ");
      location2.y = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("\nlocation2 now has the following properties:");
      Console.WriteLine("x = {0}\ny = {1}", location2.x, location2.y);

      this.Continue();

      Console.WriteLine("However, location1's properties have not been affected by location2's change\n");

      Console.WriteLine("location1 still has the following properties:");
      Console.WriteLine("x = {0}\ny = {1}", location1.x, location1.y);
    }

    public void Class() 
    {
    }
  }

  struct Location
  {
    public int x, y;
    public Location(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
  }

  class Walkthrough
  {
    static void Main(string[] args)
    {
      Menu menu = new Menu();

      menu.Struct();
    }
  }
}
