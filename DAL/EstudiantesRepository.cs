using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class EstudiantesRepository
    {
        SqlConnection connection;
        List<Estudiantes> estudiantes;
        public EstudiantesRepository(ConexionRepository conexionRepository) {

            connection = conexionRepository.connection;
            estudiantes = new List<Estudiantes>();


        }

        public List<Estudiantes> Consultar() { 
            
            //estudiantes.Clear();

            using (var sql = connection.CreateCommand()) {

                sql.CommandText = "Select * from Estudiantes";
                var reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Estudiantes estudiante = new Estudiantes();
                    estudiante = Mapear(reader);
                    estudiantes.Add(estudiante);
                    
                }
                return estudiantes;
            
            }

             
        
        }


        public Estudiantes Mapear(SqlDataReader reader) { 

            Estudiantes estudiante = new Estudiantes();
            estudiante.Id = Convert.ToInt32(reader["id"]);
            estudiante.Id_dni = (string)reader["id_dni"];
            estudiante.Nombre = (string)reader["nombre"];
            estudiante.Nombre2 = (string)reader["segundo_nombre"];
            estudiante.Apellido1 = (string)reader["apellido"];
            estudiante.Apellido2 = (string)reader["segundo_apellido"];
            estudiante.Direccion = (string)reader["direccion"];
            estudiante.Telefono = (string)reader["telefono"];
            estudiante.Fecha_Nacimiento = Convert.ToDateTime((string)reader["fecha_nacimiento"]);
            estudiante.Mail = new MailAddress((string)reader["email"]);
            estudiante.Promedio_actual = Convert.ToDecimal(reader["promedio"]);
            
            return estudiante;

        } 
    }

 
}
