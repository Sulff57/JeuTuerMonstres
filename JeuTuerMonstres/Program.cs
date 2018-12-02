using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTuerMonstres
{
    class Program
    {

        private static Random random = new Random();

        static void Main(string[] args)
        {
            Jeu1();
        }

        private static void Jeu1()
        {
            
            Joueur joueur = new Joueur(150);
            int monstresDifficilesTues = 0;
            int monstresFacilesTues = 0;
            int totalPoints = 0;

            while (joueur.EstVivant)
            {
                
                MonstreFacile monstre = FabriqueDeMonstre();
                while (joueur.EstVivant && monstre.EstVivant)
                {
                    if (joueur.LanceLeDe() >= monstre.LanceLeDe())

                    {
                        monstre.SubitDegats();
                        if (monstre is MonstreDifficile)
                        {
                            monstresDifficilesTues++;
                        }
                        else monstresFacilesTues++;
                    }
                    else
                    {
                            monstre.Attaque(joueur);
                    }
                }
            }
            totalPoints = monstresFacilesTues + monstresDifficilesTues * 2;
            Console.WriteLine("Vous avez tué " + monstresFacilesTues + " montres faciles et " + monstresDifficilesTues+" monstres difficiles." + "Votre score est donc de "+totalPoints);
            System.Threading.Thread.Sleep(5000);

        }
        private static MonstreFacile FabriqueDeMonstre()
        {

            if (random.Next(2) == 0)
            {
                return new MonstreFacile();
            }
            else
            {
                return new MonstreDifficile();
            }
        }
    }
}
