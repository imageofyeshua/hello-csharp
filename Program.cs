//using System.Runtime.InteropServices;

class Program
{
  static void Main()
  {
    Season current;
    current = Season.Summer;
    Console.WriteLine($"Season: {current}");

    int number = (int)Season.Fall;
    /*
    int[] a = new int[] { 1, 2, 3 };
    int[] b = new int[] { 1, 2, 3 };

    bool areEqual = (a == b);
    Console.WriteLine($"a equals b : {areEqual}");

    string c = "Hello";
    string d = "Hel" + "lo";
    areEqual = (c == d);
    Console.WriteLine($"c equals d : {areEqual}");
    string userName = GetUserName();
    Console.WriteLine($"{userName}, How high should I count?");
    int chosenNumber = ReadNumber();
    Count(chosenNumber);

    string GetUserName()
    {
      while (true)
      {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        if (name != "") // Empty string
          return name;
        Console.WriteLine("Let's try that again.");
      }
    }

    void Count(int numberToCountTo)
    {
      for (int current = 1; current <= numberToCountTo; current++)
        Console.WriteLine(current);
    }

    int ReadNumber()
    {
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      return number;
    }
    Console.WriteLine($"{42:#.##}");
    Console.WriteLine($"{42.1234:#.##}");

    float currentHealth = 4;
    float maxHealth = 9;
    Console.WriteLine($"{currentHealth / maxHealth:0.0%}");

    int row,
        col;
    Console.Write("Target Row? ");
    row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Target Column? ");
    col = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Deploy to:");
    Console.WriteLine($"{(row, col - 1)}");
    Console.WriteLine($"{(row - 1, col)}");
    Console.WriteLine($"{(row, col + 1)}");
    Console.WriteLine($"{(row + 1, col)}");
    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
      Console.Beep(440, 500);
    }
    else
    {
      Console.Write("\a");
    }

    string name;
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();
    Console.WriteLine("Hi, " + name);
    */

    /*
    Console.Write("What is your favorite number? ");
    string favoriteNumberText = Console.ReadLine();
    int favoriteNumber = Convert.ToInt32(favoriteNumberText);
    float favoriteNumberFloat = Convert.ToSingle(favoriteNumberText);
    double favoriteNumberDouble = Convert.ToDouble(favoriteNumberText);
    Console.WriteLine(favoriteNumber + " is a great number!");
    Console.WriteLine(favoriteNumberFloat + " is a great number in float!");
    Console.WriteLine(favoriteNumberDouble + " is a great number in double!");

    int aBigNumber = int.MaxValue;
    short aBigNegativeNumber = short.MinValue;
    double infinity = double.PositiveInfinity;
    double notAnyRealNumber = double.NaN;
    Console.WriteLine("Max Int Number: " + aBigNumber);
    Console.WriteLine("Min Short Number: " + aBigNegativeNumber);
    Console.WriteLine("Double Positive Infinity: " + infinity);
    Console.WriteLine("Not a Number: " + notAnyRealNumber);

    byte aByte = 3;
    int aInt = aByte;
    Console.WriteLine(aInt + " was a Byte Number.");

    double x = 3.0;
    float z = 3.0f;
    double xSquaredDouble = Math.Pow(x, 2);
    float zSquaredFloat = MathF.Pow(z, 2);
    Console.WriteLine("X Squared Double: " + xSquaredDouble);
    Console.WriteLine("Z Squared Float: " + zSquaredFloat);

    int y = Math.Abs(-2);
    Console.WriteLine("X Absolute Value: " + y);

    double y1 = Math.Sin(0);
    double y2 = Math.Cos(0);
    Console.WriteLine("y1: " + y1);
    Console.WriteLine("y2: " + y2);

    int smaller = Math.Min(2, 10);
    int larger = Math.Max(2, 10);
    Console.WriteLine("smaller: " + smaller);
    Console.WriteLine("larger: " + larger);

    int me = 120;
    int you = 20;
    int myHealth = Math.Clamp(me, 30, 100);
    int yourHealth = Math.Clamp(you, 30, 100);
    Console.WriteLine("My Health: " + myHealth);
    Console.WriteLine("Your Health: " + yourHealth);
    */

    /*
    StoryNode stranded = new("Stranded") {
      Text = ["It seems you failed to account for the Earth being at different points in its orbit over time."]
    };

    StoryNode destroy = new("Destroy") {
      Text = ["The device collpases, compressing all of time and space along with it."]
    };

    StoryNode start = new("Start") {
      Text = [
        "Your time machine is ready to go.",
        "Do you dare turn it on?"
      ],
      Choices = [
        new Choice("Turn it on") {
          WhenChosen = ["You are now adrift in space without a spacesuit."],
          NextNodeId = stranded.Id
        },
        new Choice("Destroy it!") {
          WhenChosen = ["You smash it to pieces!"],
          NextNodeId = destroy.Id
        }
      ]
    };

    Adventure adventure = new([start, stranded, destroy]);
    ConsoleAdventureRenderer renderer = new();
    renderer.Render(adventure.CurrentNode);
    */
  }
}
