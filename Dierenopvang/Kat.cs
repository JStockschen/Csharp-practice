namespace Dierenopvang;

public class Kat : Dier
{
    public string Kleur { get; set; }
    public Kat(String naam, int leeftijd, string kleur)
    {
        Naam = naam;
        Leeftijd = leeftijd;
        Kleur = kleur;
    }

    public void MaakGeluid()
    {
        Console.WriteLine("Kat zegt 'miauw miauw'");
    }
}