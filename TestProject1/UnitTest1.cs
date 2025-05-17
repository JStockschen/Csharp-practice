using NUnit.Framework;
using System;
using System.Collections.Generic;

using Dierenopvang;

public class DierenOpvangTests
{
    // A simple test implementation of IDier
    private class TestDier : IDier
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public void MaakGeluid() { /* Do nothing */ }
    }

    [Test]
    public void RegistreerDier_ValidDier_AddsDierToList()
    {
        // Arrange
        var opvang = new DierenOpvang("Testopvang");
        var dier = new TestDier { Naam = "Pluisje", Leeftijd = 1 };

        // Act
        opvang.RegistreerDier(dier);

        // Assert
        // Access private field 'dieren' using reflection (since it's private)
        var dierenField = typeof(DierenOpvang).GetField("dieren", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var dierenList = (List<IDier>)dierenField.GetValue(opvang);

        Assert.That(dierenList.Contains(dier));
    }

    [Test]
    public void RegistreerDier_NullDier_ThrowsArgumentNullException()
    {
        // Arrange
        var opvang = new DierenOpvang("Testopvang");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => opvang.RegistreerDier(null));
    }
}