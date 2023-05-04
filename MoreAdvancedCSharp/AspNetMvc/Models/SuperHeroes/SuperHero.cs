namespace AspNetMvc.Models.SuperHeroes;

public record SuperHero(int Id, string Name, int Age, List<string> Powers)
{
    public static List<SuperHero> Heroes = new()
    {
        new SuperHero(1, "Spiderman", 25, new List<string> { "Jumping", "Climbing" }),
        new SuperHero(2, "Superman", 36, new List<string> { "Flying", "X-Ray", "Strong" }),
        new SuperHero(3, "Batman", 45, new List<string> { "Money", "Technology" }),
    };
}