using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Personas
    {
        public int Id { get; set; }
        public string Id_dni { get; set; }
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        
        public DateTime Fecha_Nacimiento { get; set; }
        public MailAddress Mail { get; set; }
        


    }
}
