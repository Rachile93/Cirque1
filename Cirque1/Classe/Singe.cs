using System;
using System.Collections;
using System.Collections.Generic;
using Cirque1.Enum;
using Microsoft.VisualBasic.CompilerServices;

namespace Cirque1.Classe
{
    public class Singe
    {   
        private Guid id_singe = Guid.NewGuid();

        private ArrayList  tours { get; set; }

        public Singe()
        {
            tours = new ArrayList();
        }
        
        public Singe(ArrayList tours)
        {
            this.tours = tours;
        }

        public void newTours()
        {
            Console.WriteLine("donnez un nom pour ce tours");
            string nom = Console.ReadLine();
            Types t ;
            String ch = choixType();
            if (ch.Equals("Acrobatie"))
            {
                t = Types.Acrobatie;
            }
            else
            {
                t = Types.Musique;
            }

            Tours trs = new Tours(nom,t);
            tours.Add(trs);
        }

        public string choixType()
        {
            Console.WriteLine("choisisez un type de tours");
            Console.WriteLine("1-Acrobatie \n2-Musique");
            Int32 choix = 0;
            do
            {
                choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 1)
                {
                    return "Acrobatie";
                }else if (choix == 2)
                {
                    return "Musique";
                }
                
            } while (choix < 1 || choix > 2);

            return "rien";
        }
        public override string ToString()
        {
            return tours.ToString();
        }
    }
} 