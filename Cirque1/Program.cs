using System;
using System.Collections;
using Cirque1.Classe;
using Microsoft.VisualBasic.CompilerServices;

namespace Cirque1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirque c = new Cirque();
            c.Menu();
            /*
            ArrayList listDresseur = new ArrayList();
            
            

            for (int i = 0; i < 2; i++)
            {
                Dresseur dresseur = new Dresseur();
                dresseur.newDresseur();
                listDresseur.Add(dresseur);
            }
            
            
           foreach (Dresseur drs in listDresseur)
           {
               Console.WriteLine(drs.ToString());
           }*/
        }
    }
}