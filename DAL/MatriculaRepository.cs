using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MatriculaRepository
    {
        SqlConnection connection;
        List<Matricula> matriculas;
        private MatriculaRepository matriculaRepo;
        public MatriculaRepository(ConexionRepository conexionRepository)
        {

            connection = conexionRepository.connection;
            matriculas = new List<Matricula>();


        }

        public List<Matricula> Consultar()
        {

            //estudiantes.Clear();

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Select M.id, E.id_dni,E.nombre,E.segundo_nombre, E.apellido,E.segundo_apellido,E.promedio, G.grado, M.grado_id from Matricula M JOIN Estudiantes E ON M.estudiante_id=E.id_dni JOIN Grados G ON M.grado_id = G.id";
                var reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Matricula matricula = new Matricula();
                    matricula = Mapear(reader);
                    matriculas.Add(matricula);

                }
                return matriculas;

            }



        }
        public List<Matricula> BuscarCaracter(string caracter)
        {
            matriculas = Consultar();
            if (caracter == "")
            {
                return matriculas;
            }
            else
            {
                return matriculas.Where(mat => mat.Grado.Equals(caracter.ToUpper())).ToList();

            }



        }



        public Matricula Mapear(SqlDataReader reader)
        {

            Matricula matricula = new Matricula();          
            //matricula.estudiante = new Estudiantes();
            

            matricula.id = Convert.ToInt32(reader["id"]);
            matricula.EstudianteID = (string)reader["id_dni"];
            matricula.Nombre = (string)reader["nombre"];
            matricula.Nombre2 = (string)reader["segundo_nombre"];
            matricula.Apellido1 = (string)reader["apellido"];
            matricula.Apellido2 = (string)reader["segundo_apellido"];
            matricula.Grado = (string)reader["grado"];
            matricula.GradoId = Convert.ToInt32(reader["grado_id"]);
            matricula.Promedio_actual = Convert.ToDecimal(reader["promedio"]);

            return matricula;

        }

        public void Agregar(Matricula matricula)
        {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Insert Into Matricula(grado_id,estudiante_id)" +
                    "Values(@grado_id,@estudiante_id)";

                sql.Parameters.AddWithValue("@estudiante_id", matricula.EstudianteID);
                sql.Parameters.AddWithValue("@grado_id", matricula.GradoId);
                sql.ExecuteNonQuery();

            }

        }

        public Matricula ConsultarId(string identificacion)
        {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Select * from Estudiantes where id_dni = @id_dni";
                sql.Parameters.AddWithValue("@id_dni", identificacion);
                var reader = sql.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        Matricula matricula = new Matricula();
                        matricula = Mapear(reader);
                        return matricula;
                    }
                }
            }
            return null;
        }





        public void Modificar(Matricula matricula)
        {
            //using (var sql = connection.CreateCommand())
            //{

            //    sql.CommandText = "Update Matricula set nombre=@nombre,segundo_nombre=@segundo_nombre,apellido=@apellido,segundo_apellido=@segundo_apellido,direccion=@direccion,telefono=@telefono,fecha_nacimiento=@fecha_nacimiento,email=@email,promedio=@promedio where id_dni=@id_dni";


            //    sql.Parameters.AddWithValue("@id_dni", estudiante.Id_dni);
            //    sql.Parameters.AddWithValue("@nombre", estudiante.Nombre);
            //    sql.Parameters.AddWithValue("@segundo_nombre", estudiante.Nombre2);
            //    sql.Parameters.AddWithValue("@apellido", estudiante.Apellido1);
            //    sql.Parameters.AddWithValue("@segundo_apellido", estudiante.Apellido2);
            //    sql.Parameters.AddWithValue("@direccion", estudiante.Direccion);
            //    sql.Parameters.AddWithValue("@telefono", estudiante.Telefono);
            //    sql.Parameters.AddWithValue("@fecha_nacimiento", estudiante.Fecha_Nacimiento);
            //    sql.Parameters.AddWithValue("@email", estudiante.Mail.Address);
            //    sql.Parameters.AddWithValue("@promedio", estudiante.Promedio_actual);
            //    sql.ExecuteNonQuery();



            //}


        }


        public void Eliminar(string identificacion)
        {

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Delete from Matricula where id = @id";
                sql.Parameters.AddWithValue("@id", identificacion);
                sql.ExecuteNonQuery();



            }
        }

    }
}
