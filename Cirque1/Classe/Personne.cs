using System;
using System.Net.WebSockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Cirque1.Classe
{
    public class Personne
    { 
        private Guid id =     Guid.NewGuid();
        private String nom { get; set; }
        private  String prenom { get; set;  }

        public Guid Id
        {
            get
            {
                return id;
            }
        } 

        public String Nom
        {
            get
            {
                return nom;
            }
            set
            {
                this.nom = value;
            }
        }
        
        public String Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                this.prenom = value;
            }
        }
        

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public Personne()
        {
        }

        public override string ToString()
        {
            return  nom +" "+ prenom;
        }
    }
}