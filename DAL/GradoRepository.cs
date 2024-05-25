using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GradoRepository
    {
        SqlConnection connection;
        List<Grado> grados;
        private GradoRepository gradoRepo;
        public GradoRepository(ConexionRepository conexionRepository)
        {

            connection = conexionRepository.connection;
            grados = new List<Grado>();


        }

        public List<Grado> Consultar()
        {

            //estudiantes.Clear();

            using (var sql = connection.CreateCommand())
            {

                sql.CommandText = "Select * from Grados";
                var reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Grado grado = new Grado();
                    grado = Mapear(reader);
                    grados.Add(grado);

                }
                return grados;

            }



        }

        public List<Grado> BuscarCaracter(string caracter)
        {
            grados = Consultar();
            if (caracter == "")
            {
                return grados;
            }
            else
            {
                return grados.Where(gra => gra.grado.Contains(caracter)).ToList();

            }



        }

        public Grado Mapear(SqlDataReader reader)
        {

            Grado grado = new Grado();
            grado.id = Convert.ToInt32(reader["id"]);
            grado.grado = (string)reader["grado"];
            return grado;

        }
    }
}
