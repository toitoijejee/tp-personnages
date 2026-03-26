using System;

public class Magicien : Personnage
{
    protected int puissanceMagique;

    public Magicien(string nom, int PV, int puissanceMagique) : base(nom, PV)
    {
        this.puissanceMagique = puissanceMagique;
    }
    
    public override void Afficher()
    {
        Console.WriteLine($"Magicien: {nom}, PV: {pointsDeVie}, Puissance Magique: {puissanceMagique}");
    }

    public void LancerSort()
    {
        Console.WriteLine($"Le magicien lance un sort");
    }
}

