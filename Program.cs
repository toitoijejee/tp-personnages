using System;

class Program
{
    static void Main(string[] args)
    {
        // Création d'un personnage
        Personnage p = new Personnage("Arthur", 100);
        // Affichage des informations
        p.Afficher();
        // Le personnage subit des dégâts
        p.RecevoirDegats(30);
        // Affichage après dégâts
        p.Afficher();
    }
}
