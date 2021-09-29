using System;
using Cirque1.Enum;

namespace Cirque1.Classe
{
    public class Tours
    {
        private String nom_tours { get; set; }
        private Types type { get; set; }

        public Tours(string nom_tours, Types type)
        {
            this.nom_tours = nom_tours;
            this.type = type;
        }
    }
}