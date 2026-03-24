using System;

public class Personnage
{
    protected string nom;
    protected int pointsDeVie;

    public Personnage(string nom, int pointsDeVie)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
    }

    public virtual void RecevoirDegats(int degats)
    {
        pointsDeVie -= degats;
        if (pointsDeVie < 0)
            pointsDeVie = 0;
    }

    public virtual void Afficher()
    {
        Console.WriteLine($"Nom: {nom}, Points de vie: {pointsDeVie}");
    }
}

