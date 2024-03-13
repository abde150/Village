using System.ComponentModel.Design;

namespace Village
{
    public class Villageois
    {
        private bool _malade;
        private string _nom;
        private int _poids;

        public Villageois(bool malade, string nom, int poids)
        {
            this._malade = malade;
            this._nom = nom;    
            this._poids = poids;
 
        }

        public Villageois(string nom)
        {
            this._nom = nom;
            bool _malade = false;

        }

        public bool get_Malade() 
        {
            return this._malade;
        }

        public string get_Nom()
        {
            return this._nom;
        }

        public int get_Poids()
        {
            return this._poids;
        }

        public override string ToString() 
        {
            return "Le villageois se nomme " + this._nom + " et peut soulever " + this._poids + " et est " + this._malade;
        }

        public int poidsSouleve()
        {
            int resultat = 0;
            resultat = _poids / 5;

            return resultat;
        }

        public int setPoids(int poids) 
        {
            _poids = poids;
            return _poids ;
        }

        public bool soulevememepoids(Villageois a)
        {
            if (this._poids == a.get_Poids())
            {
                return true;
            }
            else return false;
        }


    }
}