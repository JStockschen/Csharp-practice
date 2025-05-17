namespace Dierenopvang;

public class Papegaai : Dier
{
    public bool KanPraten { get; set; }
    public Papegaai(String naam, int leeftijd, bool kanPraten)
    {
        Naam = naam;
        Leeftijd = leeftijd;
        KanPraten = kanPraten;
    }

    public void MaakGeluid()
    {
        Console.WriteLine("Papegaai zegt 'waa waa'");
    }
}