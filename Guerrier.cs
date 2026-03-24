using System;

public class Guerrier : Personnage
{
    protected int armure;

    public Guerrier(string nom, int pointsDeVie, int armure) : base(nom, pointsDeVie)
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
        Console.WriteLine($"Guerrier - Nom: {nom}, Points de vie: {pointsDeVie}, Armure: {armure}");
    }
}
