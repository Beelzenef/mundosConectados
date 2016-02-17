using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppF_GestionHumana
{
    class Planeta
    {
        // Propiedades

        public string NombrePlaneta { get; set; }
        public int Tamanio { get; set; }
        public string Atmosfera { get; set; }
        public int Poblacion { get; set; }
        public string Gobierno { get; set; }
        public int NivelTec { get; set; }
        public int NivelLey { get; set; }

        // Constructor

        public Planeta(string nPlaneta, int tamanio, string tipoAtmosfera, int poblac, string tipoGob, int nTec, int nLey)
        {
            NombrePlaneta = nPlaneta;
            Tamanio = tamanio;
            Atmosfera = tipoAtmosfera;
            Poblacion = poblac;
            Gobierno = tipoGob;
            NivelLey = nLey;
            NivelTec = nTec;
        }

        // Incluir métodos para generación de planetas aleatorios

        // Base naval
        // Tamaño
        // Atmósfera
        // Hidrografía
        // Población
        // Gobierno
        // Nivel de legislación
        // Nivel de tecnología

    }
}
