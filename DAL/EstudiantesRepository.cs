using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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
            estudiante.Fecha_Nacimiento = (string)reader["fecha_nacimiento"];
            estudiante.Mail = new MailAddress((string)reader["email"]);
            estudiante.Promedio_actual = Convert.ToDecimal(reader["promedio"]);
            
            return estudiante;

        }

        public void Agregar(Estudiantes estudiante) {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Insert Into Estudiantes(id_dni,nombre,segundo_nombre,apellido,segundo_apellido,direccion,telefono,fecha_nacimiento,email,promedio)" +
                    "Values(@id_dni,@nombre,@segundo_nombre,@apellido,@segundo_apellido,@direccion,@telefono,@fecha_nacimiento,@email,@promedio)";

                sql.Parameters.AddWithValue("@id_dni", estudiante.Id_dni);
                sql.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                sql.Parameters.AddWithValue("@segundo_nombre", estudiante.Nombre2);
                sql.Parameters.AddWithValue("@apellido", estudiante.Apellido1);
                sql.Parameters.AddWithValue("@segundo_apellido", estudiante.Apellido2);
                sql.Parameters.AddWithValue("@direccion", estudiante.Direccion);
                sql.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                sql.Parameters.AddWithValue("@fecha_nacimiento", estudiante.Fecha_Nacimiento);
                sql.Parameters.AddWithValue("@email", estudiante.Mail.Address);
                sql.Parameters.AddWithValue("@promedio", estudiante.Promedio_actual);
                sql.ExecuteNonQuery();



            }

        }

        public Estudiantes ConsultarId(string identificacion) {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Select * from Estudiantes where id_dni = @id_dni";
                sql.Parameters.AddWithValue("@id_dni", identificacion);
                var reader = sql.ExecuteReader();
                if (reader.HasRows) {

                    while (reader.Read()) {
                        
                        Estudiantes estudiante = new Estudiantes();
                        estudiante = Mapear(reader);
                        return estudiante;                    
                    }                
                }                
            }
            return null;
        }


     


        public void Modificar(Estudiantes estudiante) {
        using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Update Estudiantes set nombre=@nombre,segundo_nombre=@segundo_nombre,apellido=@apellido,segundo_apellido=@segundo_apellido,direccion=@direccion,telefono=@telefono,fecha_nacimiento=@fecha_nacimiento,email=@email,promedio=@promedio where id_dni=@id_dni";
                    

                sql.Parameters.AddWithValue("@id_dni", estudiante.Id_dni);
                sql.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                sql.Parameters.AddWithValue("@segundo_nombre", estudiante.Nombre2);
                sql.Parameters.AddWithValue("@apellido", estudiante.Apellido1);
                sql.Parameters.AddWithValue("@segundo_apellido", estudiante.Apellido2);
                sql.Parameters.AddWithValue("@direccion", estudiante.Direccion);
                sql.Parameters.AddWithValue("@telefono", estudiante.Telefono);
                sql.Parameters.AddWithValue("@fecha_nacimiento", estudiante.Fecha_Nacimiento);
                sql.Parameters.AddWithValue("@email", estudiante.Mail.Address);
                sql.Parameters.AddWithValue("@promedio", estudiante.Promedio_actual);
                sql.ExecuteNonQuery();



            }
        
        
        }


        public void Eliminar(string identificacion) {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Delete from Estudiantes where id_dni = @id_dni";
                sql.Parameters.AddWithValue("@id_dni", identificacion);
                sql.ExecuteNonQuery();

            
            
            }
        }
    }

 
}
