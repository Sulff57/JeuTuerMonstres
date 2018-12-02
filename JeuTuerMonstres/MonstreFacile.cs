using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTuerMonstres
{
    class MonstreFacile
    {

        public const int degats = 10;
        public bool EstVivant { get; private set; }

        protected De de;


        public MonstreFacile()
        {
            de = new De();
            EstVivant = true;
        }

        public void SubitDegats()
        {
            EstVivant = false;
        }

        public virtual void Attaque(Joueur joueur)
        {
            
            joueur.SubitsDegats(degats);
        }

        public int LanceLeDe()
        {
            return de.LanceLeDe();
        }
    }
}
