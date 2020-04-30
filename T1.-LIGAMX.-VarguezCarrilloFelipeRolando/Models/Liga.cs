using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LigaMX.Models
{
    public class Liga
    {
        public int Id { get; set; }
        public string Equipo { get; set; }
        public string DirectorTecnico { get; set; }
        public string Estadio { get; set; }
        public int Capacidad { get; set; }
        public DateTime? Fundacion { get; set; }
        public int Campeonatos { get; set; }
    }
}