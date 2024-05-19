using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class EspecialidadRepository
    {
            SqlConnection connection;
            List<Especialidad> especialidades;
            private EspecialidadRepository especialidadRepo;
            public EspecialidadRepository(ConexionRepository conexionRepository)
            {

                connection = conexionRepository.connection;
                especialidades = new List<Especialidad>();


            }

            public List<Especialidad> Consultar()
            {

                //estudiantes.Clear();

                using (var sql = connection.CreateCommand())
                {

                    sql.CommandText = "Select * from Especialidad";
                    var reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        Especialidad especialidad = new Especialidad();
                        especialidad = Mapear(reader);
                        especialidades.Add(especialidad);

                    }
                    return especialidades;

                }



            }
            public List<Especialidad> BuscarCaracter(string caracter)
            {
                especialidades = Consultar();
                if (caracter == "")
                {
                    return especialidades;
                }
                else
                {
                    return especialidades.Where(esp => esp.especialidad.Contains(caracter)).ToList();

                }



            }



            public Especialidad Mapear(SqlDataReader reader)
            {

                Especialidad especialidad = new Especialidad();
                especialidad.id = Convert.ToInt32(reader["id"]);
                especialidad.especialidad = (string)reader["especialidad"];
                return especialidad;

            }

            public void Agregar(Especialidad especialidad)
            {

                using (var sql = connection.CreateCommand())
                {

                    sql.CommandText = "Insert Into Especialidad(especialidad)" +
                        "Values(@especialidad)";

                    sql.Parameters.AddWithValue("@id", especialidad.id);
                    sql.Parameters.AddWithValue("@especialidad", especialidad.especialidad);
                    sql.ExecuteNonQuery();



                }

            }

            public Especialidad ConsultarId(string identificacion)
            {

                using (var sql = connection.CreateCommand())
                {

                    sql.CommandText = "Select * from Especialidad where id = @id";
                    sql.Parameters.AddWithValue("@id", identificacion);
                    var reader = sql.ExecuteReader();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            Especialidad especialidad = new Especialidad();
                            especialidad = Mapear(reader);
                            return especialidad;
                        }
                    }
                }
                return null;
            }





            public void Modificar(Especialidad especialidad)
            {
                using (var sql = connection.CreateCommand())
                {

                    sql.CommandText = "Update Especialidad set especialidad=@especialidad where id=@id";
                    sql.Parameters.AddWithValue("@id", especialidad.id);
                    sql.Parameters.AddWithValue("@especialidad", especialidad.especialidad);
                    sql.ExecuteNonQuery();

                }

            }


            public void Eliminar(string identificacion)
            {

                using (var sql = connection.CreateCommand())
                {

                    sql.CommandText = "Delete from Especialidad where id = @id";
                    sql.Parameters.AddWithValue("@id", identificacion);
                    sql.ExecuteNonQuery();



                }
            }


        }
    }


