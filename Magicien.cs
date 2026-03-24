using System;

public class Magicien : Personnage
{
    protected int puissanceMagique;

    public Magicien(string nom, int pointsDeVie, int puissanceMagique) : base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }

    public override void Afficher()
    {
        Console.WriteLine($"Magicien - Nom: {nom}, Points de vie: {pointsDeVie}, Puissance Magique: {puissanceMagique}");
    }

    public void LancerSort()
    {
        Console.WriteLine($"{nom} lance un sort avec une puissance de {puissanceMagique} !");
    }
}
