using System;

class Program
{
    static void Main(string[] args)
    {
        Guerrier g = new Guerrier("Conan", 120, 10);
        g.Afficher();
        g.RecevoirDegats(30);
        g.Afficher();

        Console.WriteLine();

        Magicien m = new Magicien("Gandalf", 80, 50);
        m.Afficher();
        m.LancerSort();
    }
}
