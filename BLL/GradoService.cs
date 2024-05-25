using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GradoService
    {
        private ConexionRepository conexionRepository;
        private GradoRepository gradoRepository;

        List<Grado> grados;
        Grado grado;



        public GradoService(string conexion)
        {

            conexionRepository = new ConexionRepository(conexion);
            gradoRepository = new GradoRepository(conexionRepository);

        }

        public GradoService() { }

        public List<Grado> Consultar()
        {

            try
            {
                grados = new List<Grado>();
                conexionRepository.Open();
                grados = gradoRepository.Consultar();
                return grados;

            }
            catch (Exception e)
            {

                string msg = $"Error: " + e.Message.ToString();


            }
            finally
            {

                conexionRepository.Close();


            }

            return null;

        }

        public List<Grado> BuscarCaracter(string caracter)
        {

            try
            {
                conexionRepository.Open();
                return gradoRepository.BuscarCaracter(caracter);

            }
            catch (Exception e)
            {

                string msg = $"Error: " + e.Message.ToString();




            }
            finally
            {
                conexionRepository.Close();
            }

            return null;


        }




    }
}
