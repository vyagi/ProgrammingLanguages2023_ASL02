namespace AspNetWebApi.Models;

public class SuperHero
{
    public static List<SuperHero> Heroes = new()
    {
        new SuperHero(1, "Spiderman", 25, new List<string> { "Jumping", "Climbing" }),
        new SuperHero(2, "Superman", 36, new List<string> { "Flying", "X-Ray", "Strong" }),
        new SuperHero(3, "Batman", 45, new List<string> { "Money", "Technology" }),
    };

    public SuperHero(int id, string name, int age, List<string> powers)
    {
        Id = id;
        Name = name;
        Age = age;
        Powers = powers;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Powers { get; set; }
}