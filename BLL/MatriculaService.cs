using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MatriculaService
    {

        private ConexionRepository conexionRepository;
        private MatriculaRepository matriculaRepository;

        List<Matricula> matriculas;
        Matricula matricula;



        public MatriculaService(string conexion)
        {

            conexionRepository = new ConexionRepository(conexion);
            matriculaRepository = new MatriculaRepository(conexionRepository);

        }

        public MatriculaService() { }

        public List<Matricula> Consultar()
        {

            try
            {
                matriculas = new List<Matricula>();
                conexionRepository.Open();
                matriculas = matriculaRepository.Consultar();
                return matriculas;

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


        public string Agregar(Matricula matricula)
        {


            try
            {

                conexionRepository.Open();
                matriculaRepository.Agregar(matricula);

                return $"La matricula en el grado {matricula.GradoId +" "+ matricula.EstudianteID} se han registrado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al registrar Matricula: " + e.Message.ToString();


            }
            finally
            {

                conexionRepository.Close();


            }

            return null;


        }


        public Matricula ConsultarId(string identificacion)
        {
            try
            {

                conexionRepository.Open();
                matricula = new Matricula();
                matricula = matriculaRepository.ConsultarId(identificacion);
                return matricula;

            }
            catch (Exception e)
            {
                string msg = $"Error al modificar matricula: " + e.Message.ToString();

            }
            finally
            {

                conexionRepository.Close();

            }

            return null;

        }

        public string Modificar(Matricula matricula)
        {
            try
            {

                conexionRepository.Open();
                matriculaRepository.Modificar(matricula);
                return "Matricula modificado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al modificar Matricula: " + e.Message.ToString();

            }
            finally
            {

                conexionRepository.Close();

            }

            return null;

        }

        public string Eliminar(string identificacion)
        {

            try
            {

                conexionRepository.Open();
                matriculaRepository.Eliminar(identificacion);
                return "Matricula Eliminado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al eliminar Matricula: " + e.Message.ToString();

            }
            finally
            {

                conexionRepository.Close();

            }

            return null;



        }


        public List<Matricula> BuscarCaracter(string caracter)
        {

            try
            {
                conexionRepository.Open();
                return matriculaRepository.BuscarCaracter(caracter);

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

