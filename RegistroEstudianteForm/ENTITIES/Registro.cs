using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudianteForm.ENTITIES
{
    public class Registro
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Matricula { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public int TotalCreditos { get; set; }
        public string Carrera { get; set; }

        public Registro() 
        {
            TotalCreditos = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            Matricula = string.Empty;  
            Telefono = string.Empty;
            Cedula = string.Empty;
            Carrera = string.Empty;
        }
    }
}
