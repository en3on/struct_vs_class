== Class vs Struct ==

Welcome! Let's discover the difference between a Class and a Struct in C#!

<!-- readline -->

First, let's create a struct. We'll call it Location:

Struct Location
{
  public int x, y;

  public Location(int x, int y)
  {
    this.x = x;
    this.y = y;
  }
}

<!-- readline -->

Location has 2 public integers: x and y

Let's create our first Location instance!

Enter the x value for location1
<!-- readinput -->
Enter the y value for location1
<!-- readinput -->

Location location1 = new Location({0}, {1});

<!-- readline -->

location1 has the following properties:
location1.x = {0}
location1.y = {0}

<!-- readline -->

Let's create another location based on location1

Location location2 = location1;

location2 has the following properties:
location2.x = {0}
location2.y = {0}

<!-- readline -->

Let's change location2's properties

Enter the new x value for location2
<!-- readinput -->

Enter the new y value for location2
<!-- readinput -->


location2 now has the following properties:
location2.x = {0}
location2.y = {0}

<!-- readline -->

However, location1's properties have not been affected by location2's change

location1 still has the following properties:
location1.x = {0}
location1.y = {0}
