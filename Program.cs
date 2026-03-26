using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Personnage> personnages = new List<Personnage>();
        personnages.Add(new Guerrier("Arthur", 100, 20));
        personnages.Add(new Magicien("Merlin", 80, 50));
        
        personnages.Add(new Archer("Legolas", 90, 85));

        Personnage pTest = new Personnage("Testeur", 150);
        Console.WriteLine(pTest); 

        foreach (Personnage p in personnages)
        {
            p.Afficher();
            if (p is Guerrier guerrier)
            {
                guerrier.Attaquer();
            }
            else if (p is Magicien magicien)
            {
                magicien.LancerSort();
            }
            else if (p is Archer archer)
            {
                archer.Tirer();
            }
        }

        try
        {
            Console.WriteLine("Tentative de casting d'un magicien en guerrier...");
            Guerrier mauvaisGuerrier = (Guerrier)personnages[1];
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Erreur capturée : Impossible de convertir un magicien en guerrier !");
        }

        Console.WriteLine("\nCorrection avec vérification de type :");
        if (personnages[1] is Guerrier g)
        {
            g.Attaquer();
        }
        else
        {
            Console.WriteLine("L'objet à l'index 1 n'est pas un Guerrier.");
        }
    }
}
