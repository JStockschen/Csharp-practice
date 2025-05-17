// Demonstrates List from an Interface linked to an object.
// Adds item to list
// Writes out list
namespace Dierenopvang;

public class DierenOpvang
{
    public string Naam { get; set; }
    private List<IDier> dieren;

    public DierenOpvang(string naam)
    {
        Naam = naam;
        dieren = new List<IDier>();
    }
    public void RegistreerDier(IDier dier)
    {
        if (dier == null)
        {
            throw new ArgumentNullException(nameof(dier), "Dier mag niet null zijn.");
        }
        dieren.Add(dier);
        Console.WriteLine($"{dier.Naam} is geregistreerd in de opvang.");
    }
    
    public void VoerControleUit()
    {
        Console.WriteLine($"Dieren in opvang {Naam}:");
        foreach (var dier in dieren)
        {
            Console.WriteLine($"- {dier.Naam}, {dier.Leeftijd} jaar oud");
        }
    }
}
