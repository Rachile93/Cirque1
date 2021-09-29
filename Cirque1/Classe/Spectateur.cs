using System;
using System.Collections;
using System.Collections.Generic;
using Cirque1.Enum;

namespace Cirque1.Classe
{
    public class Spectateur : Personne
    {

        private ArrayList dresseur;
        private Reaction _reaction;


        public Reaction _Reaction
        {
            get
            {
                return this._reaction;
            }
            set
            {
                this._reaction = value;
            }
        }

        public ArrayList Dresseur
        {
            get
            {
                return this.dresseur;
            }
            set
            {
                this.dresseur = value;
            }
        }
        public Spectateur(string nom, string prenom) : base(nom,prenom)
        {
            dresseur = new ArrayList();
            Dresseur = new ArrayList();
        }

        public Spectateur()
        {
            dresseur = new ArrayList();
            Dresseur = new ArrayList();
        }
        
        public void croiserDressseur(ArrayList ListDr)
        {
            foreach (Dresseur drs in ListDr)
            {
                Console.WriteLine(drs.ToString());
            }
        }

        public void newSpectateur()
        {
            Console.WriteLine("veuillez encoder un nouveau Spectateur : ");
            Console.WriteLine("nom :");
            base.Nom = Console.ReadLine();
            Console.WriteLine("prenom :");
            base.Prenom = Console.ReadLine();
        }

    }
}