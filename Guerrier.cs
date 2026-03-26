using System;

public class Guerrier : Personnage
{
    protected int armure;

    public Guerrier(string nom, int PV, int armure) : base(nom, PV)
    {
        this.armure = armure;
    }

    public override void RecevoirDegats(int degats)
    {
        int degatsReduits = degats - armure;
        if (degatsReduits < 0) degatsReduits = 0;
        base.RecevoirDegats(degatsReduits);
    }

    public override void Afficher()
    {
        Console.WriteLine($"Guerrier: {nom}, PV: {pointsDeVie}, Armure: {armure}");
    }

    public void Attaquer()
    {
        Console.WriteLine($"Le guerrier attaque");
    }
}
