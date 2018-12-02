using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTuerMonstres
{
    class MonstreDifficile : MonstreFacile
    {
        const int degatsMagiques = 5;
        

        
        public override void Attaque(Joueur joueur)
        {
            base.Attaque(joueur);
            int jetDeDe = de.LanceLeDe();
            if (jetDeDe != 6)
            {
                joueur.SubitsDegats(degatsMagiques * degatsMagiques);
            }
        }
    }
}
