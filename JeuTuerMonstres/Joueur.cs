using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTuerMonstres
{
    class Joueur
    {

        private De de;
        public int PtsDeVie { get; private set; }

        public bool EstVivant
        {
            get { return PtsDeVie > 0; }
        }

        public Joueur(int ptsDeVie) {
            PtsDeVie = ptsDeVie;
            de = new De();
        }

        public void Attaque(MonstreFacile monstre)
        {
            monstre.SubitDegats();
        }


        public void SubitsDegats(int degats)
        {
            if (!BouclierFonctionne())
            {
                PtsDeVie -= degats;
            }
        }

        public bool BouclierFonctionne()
        {
            return (de.LanceLeDe() <= 2);
        }

        public int LanceLeDe()
        {
            return de.LanceLeDe();
        }
    }
}
