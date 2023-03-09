//Demos.NullableDemo();
//Demos.StructClassesDemo();
//Demos.GenericDemos();
//Demos.ExtensionMethodsDemo();
//Demos.EnumerableDemo();
//Demos.AnonymousTypesDemo();
//Demos.TupleDemo();

int i = 10;
object x = i;//boxing

int j = (int)x;//unboxing

public class Demos
{
    public static void NullableDemo()
    {
        //int? is the same as Nullable<int>

        int? height = 180;
        bool? condition = false;
        string name = "Marcin";

        //In C# we basically have two types of types
        // There are classes (reference types) like string, array, List, many others
        // There are structs (value types) like int, decimal, float, DateTime, bool and some other

        //Before C# 8.0
        //classes are nullable
        //structs are NOT nullable

        //Now C# introduced a concept of nullable and not nullable reference types
        //so you can have for example string and string? (it was not possible in old C#) 
        // - adoption of this is very slow

        Console.WriteLine(height);
        Console.WriteLine(condition);
        Console.WriteLine(name);

        height = null;
        condition = null;
        name = null;

        Console.WriteLine(height);
        Console.WriteLine(condition);
        Console.WriteLine(name);

        Console.WriteLine(height.HasValue);
        //Console.WriteLine(height.Value); // it throws exception
    }

    public static void StructClassesDemo()
    {
        var p1 = new Point(5, 7);
        var p2 = new Point(5, 7);

        Console.WriteLine($"({p1.X},{p1.Y})");
        Console.WriteLine($"({p2.X},{p2.Y})");

        Console.WriteLine(p1.Equals(p2));

        ChangePoint(p1);
        Console.WriteLine($"({p1.X},{p1.Y})");

        void ChangePoint(Point p)
        {
            p.X = 100;
            p.Y = 100;
        }
    }

    public static void GenericDemos()
    {
        var p1 = new Pair<int, int>(10, 20);
        var p2 = new Pair<int, int>(-10, 30);

        var p3 = new Pair<string, string>("James", "Bond");
        var p4 = new Pair<DateTime, DateTime>(DateTime.Now, DateTime.Now.AddDays(10));

        Console.WriteLine(p1.A + p1.B);
        Console.WriteLine(p3.A.Length > p3.B.Length);
        Console.WriteLine(p4.B - p4.A);

        var p5 = new Pair<int, string>(10, "Wicky");
    }

    public static void ExtensionMethodsDemo()
    {
        var name = "marcin"; // -> "Marcin"

        var capitalized1 = StringUtilities.Capitalize(name);
        var capitalized2 = name.Capitalize();

        Console.WriteLine(capitalized1);
        Console.WriteLine(capitalized2);

        Console.WriteLine(5.IsOdd());
        Console.WriteLine(6.IsOdd());
        Console.WriteLine(5.IsPrime());
        Console.WriteLine(6.IsPrime());

        //some linq
        var heights = new[] { 170, 160, 150 };
        Console.WriteLine(heights.Any(x=>x > 150));
        Console.WriteLine(Enumerable.Any(heights, x=>x>150));

        var something = 
            heights
            .Where(x => x > 150)
            .OrderBy(x => x)
            .Select(x => x % 3)
            .OrderByDescending(x => x);

        var theSame = Enumerable.OrderByDescending(
            Enumerable.Select(
                Enumerable.OrderBy(
                    Enumerable.Where(heights, 
                        x => x > 150), 
                    x => x), 
                x => x % 3), 
            x => x);

    }

    public static void EnumerableDemo()
    {
        var heights = new[] { 180, 178, 150 };

        foreach (var height in heights)
        {
            Console.WriteLine(height);
        }

        var weights = new List<int> { 100, 70, 92, 80 };

        foreach (var weight in weights)
        {
            Console.WriteLine(weight);
        }

        Console.WriteLine(heights.Max());
        Console.WriteLine(weights.Max());

        var personNames = new Names { FirstName = "James", SecondName = "Junior", LastName = "Bond" };

        //foreach (var name in personNames)
        //{
        //    Console.WriteLine(name);
        //}

        Console.WriteLine(personNames.Skip(1).First());

        //linq is LAZY

        var twoBiggestWeights = weights
            .OrderByDescending(x => x)
            .Take(2);

        weights.Add(98);
        foreach (var bigWeight in twoBiggestWeights)
        {
            //It's extremely important to understand it
            Console.WriteLine(bigWeight);//because linq operators are lazy (most of them)
        }

    }

    public static void AnonymousTypesDemo()
    {
        var p1 = new Person("James", 50, "Spy");
        var p2 = new Person("James", 50, "Spy");

        var persons = new[] {
            p1,
            p2,
            new ("Jane", 40, "Nurse"),
            new ("Kate",20, "Student") };

        var info = persons
            .Select(x => new { Description = $"{x.Name} ({x.Occupation})", Age = x.Age });

        foreach (var personInfo in info)
        {
            Console.WriteLine(personInfo.GetType());
            Console.WriteLine($"{personInfo.Description} is {personInfo.Age}");
        }
    }

    public static void TupleDemo()
    {
        var p1 = new Person("James", 50, "Spy");
        var p2 = new Person("James", 50, "Spy");

        var persons = new[] {
            p1,
            p2,
            new ("Jane", 40, "Nurse"),
            new ("Kate",20, "Student") };

        var info = persons
            .Select(x => ($"{x.Name} ({x.Occupation})", x.Age));
        
        Display(info);

        void Display(IEnumerable<(string Description, int Age)> collection)
        {
            foreach (var personInfo in collection)
            {
                Console.WriteLine(personInfo.GetType());
                Console.WriteLine($"{personInfo.Description} is {personInfo.Age}");
            }
        }
    }
}