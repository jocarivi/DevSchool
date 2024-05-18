using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Linq;
using System.Net.Mail;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DocentesRepository
    {
        SqlConnection connection;
        List<Docente> docentes;
        private DocentesRepository docentesRepo;

        public DocentesRepository(ConexionRepository conexionRepository)
        {

            connection = conexionRepository.connection;
            docentes = new List<Docente>();


        }

        public List<Docente> Consultar()
        {

            //docente.Clear();

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Select * from Docente";
                var reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Docente docente = new Docente();
                    docente = Mapear(reader);
                    docentes.Add(docente);

                }
                return docentes;

            }
        }
        public List<Docente> BuscarCaracter(string caracter)
        {


            docentes = Consultar();
            return docentes.Where(doce => doce.Id_dni.Contains(caracter)).ToList();
            
        }

        public Docente Mapear(SqlDataReader reader)
        {

            Docente docente = new Docente();
            docente.Id = Convert.ToInt32(reader["id"]);
            docente.Id_dni = (string)reader["id_dni"];
            docente.Nombre = (string)reader["nombre"];
            docente.Nombre2 = (string)reader["segundo_nombre"];
            docente.Apellido1 = (string)reader["apellido"];
            docente.Apellido2 = (string)reader["segundo_apellido"];
            docente.Direccion = (string)reader["direccion"];
            docente.Telefono = (string)reader["telefono"];
            docente.Fecha_Nacimiento = (string)reader["fecha_nacimiento"];
            docente.Mail = new MailAddress((string)reader["email"]);
            docente.Especialidad = (string)reader["especialidad"];




            return docente;

        }

        public void Agregar(Docente docente)
        {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Insert Into Docente(id_dni,nombre,segundo_nombre,apellido,segundo_apellido,direccion,telefono,fecha_nacimiento,email,especialidad)" +
                    "Values(@id_dni,@nombre,@segundo_nombre,@apellido,@segundo_apellido,@direccion,@telefono,@fecha_nacimiento,@email,@especialidad)";

                sql.Parameters.AddWithValue("@id_dni", docente.Id_dni);
                sql.Parameters.AddWithValue("@nombre", docente.Nombre);
                sql.Parameters.AddWithValue("@segundo_nombre", docente.Nombre2);
                sql.Parameters.AddWithValue("@apellido", docente.Apellido1);
                sql.Parameters.AddWithValue("@segundo_apellido", docente.Apellido2);
                sql.Parameters.AddWithValue("@direccion", docente.Direccion);
                sql.Parameters.AddWithValue("@telefono", docente.Telefono);
                sql.Parameters.AddWithValue("@fecha_nacimiento", docente.Fecha_Nacimiento);
                sql.Parameters.AddWithValue("@email", docente.Mail.Address);
                sql.Parameters.AddWithValue("@especialidad", docente.Especialidad);
                
               
                sql.ExecuteNonQuery();



            }

        }


        public Docente ConsultarId(string identificacion)
        {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Select * from Docente where id_dni = @id_dni";
                sql.Parameters.AddWithValue("@id_dni", identificacion);
                var reader = sql.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        Docente docente = new Docente();
                        docente = Mapear(reader);
                        return docente;
                    }
                }
            }
            return null;
        }





        public void Modificar(Docente docente)
        {
            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Update Docente set nombre=@nombre,segundo_nombre=@segundo_nombre,apellido=@apellido,segundo_apellido=@segundo_apellido,direccion=@direccion,telefono=@telefono,fecha_nacimiento=@fecha_nacimiento,email=@email,especialidad=@especialidad, where id_dni=@id_dni";


                sql.Parameters.AddWithValue("@id_dni", docente.Id_dni);
                sql.Parameters.AddWithValue("@nombre", docente.Nombre);
                sql.Parameters.AddWithValue("@segundo_nombre", docente.Nombre2);
                sql.Parameters.AddWithValue("@apellido", docente.Apellido1);
                sql.Parameters.AddWithValue("@segundo_apellido", docente.Apellido2);
                sql.Parameters.AddWithValue("@direccion", docente.Direccion);
                sql.Parameters.AddWithValue("@telefono", docente.Telefono);
                sql.Parameters.AddWithValue("@fecha_nacimiento", docente.Fecha_Nacimiento);
                sql.Parameters.AddWithValue("@email", docente.Mail.Address);
                sql.Parameters.AddWithValue("@especialidad", docente.Especialidad);

                sql.ExecuteNonQuery();



            }


        }

        public void Eliminar(string identificacion)
        {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Delete from Docente where id_dni = @id_dni";
                sql.Parameters.AddWithValue("@id_dni", identificacion);
                sql.ExecuteNonQuery();



            }
        }
    }
}
