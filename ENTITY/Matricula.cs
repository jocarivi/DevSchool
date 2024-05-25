using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Matricula
    {

        public int id { get; set; }        
        public string EstudianteID { get; set; }        
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public decimal Promedio_actual { get; set; }
        public int GradoId { get; set; }

        public string Grado { get; set; }
     

              

        //public List<Estudiantes> estudiante { get; set;} 

    }
}
