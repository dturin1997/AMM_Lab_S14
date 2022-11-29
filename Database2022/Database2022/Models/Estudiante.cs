using System;
using System.Collections.Generic;
using System.Text;

namespace Database2022.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Nota { get; set; }
        public bool Aprobado { get; set; }

    }
}
