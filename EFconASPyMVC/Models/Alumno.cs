using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFconASPyMVC.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        //Clave foránea con respecto a Clase
        public int ClaseId { get; set; }

        //propiedad navegacional
        public Usuario Usuario { get; set; }

        //propiedad navegacional
        public List<AlumnoTareas> AlumnoTareas { get; set; }

        //propiedad navegacional 
        public Clase Clase { get; set; }
    }
}
