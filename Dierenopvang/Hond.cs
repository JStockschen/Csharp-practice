// Create class
namespace Dierenopvang;

public class Hond : Dier
{
    public string Ras { get; set; }
    public Hond(String naam, int leeftijd, string ras)
    {
        Naam = naam;
        Leeftijd = leeftijd;
        Ras = ras;
    }
    public void MaakGeluid()
    {
        Console.WriteLine("Hond zegt 'ruff ruff'");
    }
}
