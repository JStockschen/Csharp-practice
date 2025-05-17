namespace Dierenopvang;

public interface IDier
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }

    public void MaakGeluid()
    {
        Console.WriteLine("Het maakt geluid.");
    }
}