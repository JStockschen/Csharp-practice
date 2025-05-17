// Composition


namespace Dierenopvang;

public class Dierenarts
{
    public string Naam { get; set; }

    public Dierenarts(string naam)
    {
        Naam = naam;
    }

    private Dier _dier;

    public void VoerCheckUit(Dier dier)
    {
        _dier = dier;
        Console.WriteLine($"{Naam} voert de check uit op {dier.Naam}.");
    }
}
