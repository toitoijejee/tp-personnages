using System;

public class Archer : Personnage
{
    protected int precision;

    public Archer(string nom, int pointsDeVie, int precision) : base(nom, pointsDeVie)
    {
        this.precision = precision;
    }

    public override void Afficher()
    {
        Console.WriteLine($"Archer: {nom}, PV: {pointsDeVie}, Précision: {precision}");
    }

    public void Tirer()
    {
        Console.WriteLine($"L’archer tire une flèche avec une précision de {precision}");
    }

    public override string ToString()
    {
        return $"[Archer] Nom: {nom}, Points de vie: {pointsDeVie}, Précision: {precision}";
    }
}
