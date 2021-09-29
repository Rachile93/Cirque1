using System;

namespace Cirque1.Classe
{
    public class Dresseur : Personne
    {
        
        private Singe singe { get; set; }

        public Singe _singe
        {
            get
            {
                return this.singe;
            }
            set
            {
                this.singe = value;
            }
        }
        
        
        public Dresseur(string nom ,string prenom ) :base(nom,prenom)
        {
            singe = new Singe();
        }

        public Dresseur()
        {
            singe = new Singe();
        }

        public void newDresseur()
        {
            Console.WriteLine("veuillez encoder un nouveau dresseur : ");
            Console.WriteLine("nom :");
            base.Nom = Console.ReadLine();
            Console.WriteLine("prenom :");
            base.Prenom = Console.ReadLine();
            singe.newTours();
            singe.newTours();
        }

        public override string ToString()
        {
            return base.ToString()+" "+_singe;
        }
    }
}