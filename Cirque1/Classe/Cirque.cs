using System;
using System.Collections;

namespace Cirque1.Classe
{
    public class Cirque
    {
        private Spectateur _spectateurEncours;
        private ArrayList _listDresseur;
        private ArrayList _listSpectateur;

        public Cirque()
        {
            _listDresseur = new ArrayList();
            _listSpectateur = new ArrayList();
            _spectateurEncours = new Spectateur();
        }
        
        
        public void Menu()
        {
            Console.WriteLine("1-Encoder spectateur \n2-Encoder Dreseur\n3-cirque\n4-fin");
            Int32 choix = 0;
            
            do
            {
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1 : 
                        Spectateur spectateur= new Spectateur();
                        spectateur.newSpectateur();
                        _listSpectateur.Add(spectateur);
                        Console.WriteLine("le spectateur "+spectateur.Nom+" "+spectateur.Prenom+" à été encoder avec succes\n");
                        Menu();
                        break;
                    case 2:
                         Dresseur dresseur = new Dresseur();
                         dresseur.newDresseur();
                         _listDresseur.Add(dresseur);
                         Console.WriteLine("le spectateur "+dresseur.Nom+" "+dresseur.Prenom+" à été encoder avec succes\n");
                         Menu();
                         break;
                    case 3:
                        selectSpectateur();
                        selectDresseur();
                        break;
                    case 4:
                        Console.WriteLine("Terminer");
                        break;

                }
                
            } while (choix < 1 || choix > 4);

        }
        
        public void selectSpectateur()
        {
            int i = 1;
            Int32 choix = 0;
            foreach (Spectateur spt in _listSpectateur)
            {
                Console.WriteLine(i+"-"+spt.Nom+" "+spt.Prenom);
                i++;
            }

            do
            {
                choix = Convert.ToInt32(Console.ReadLine());
                if (choix > 0 && choix <= _listSpectateur.Count)
                {
                    _spectateurEncours =(Spectateur) _listSpectateur[choix-1];
                    Console.WriteLine(_spectateurEncours.Nom+"  "+_spectateurEncours.Prenom);
                }
                
            } while (choix < 1 || choix > _listSpectateur.Count);

        }
        
        public void selectDresseur()
        {
            int i = 1;
            Int32 choix = 0;
            foreach (Dresseur dress in _listDresseur)
            {
                Console.WriteLine(i+"-"+dress.Nom+" "+dress.Prenom);
                i++;
            }

            do
            {
                choix = Convert.ToInt32(Console.ReadLine());
                if (choix > 0 && choix <= _listDresseur.Count)
                {
                    _spectateurEncours.Dresseur.Add(_listDresseur[choix-1]);
                    Console.WriteLine(_spectateurEncours.Dresseur[0]);
                }
                
            } while (choix < 1 || choix > _listDresseur.Count);
        }

        public void reactionSpectateur()
        {
           // if(_spectateurEncours.Dresseur[0].)
        }
    }
}