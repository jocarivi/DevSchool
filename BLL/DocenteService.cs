using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class DocenteService
    {
        private ConexionRepository conexionRepository;
        private DocentesRepository docenteRepository;

        List<Docente> docentes;
        Docente docente;


        public DocenteService(string conexion)
        {

            conexionRepository = new ConexionRepository(conexion);
            docenteRepository = new DocentesRepository(conexionRepository);

        }

        public DocenteService() { }

        public List<Docente> Consultar()
        {

            try
            {
                docentes = new List<Docente>();
                conexionRepository.Open();
                docentes = docenteRepository.Consultar();
                return docentes;

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

        public string Agregar(Docente docente)
        {


            try
            {

                conexionRepository.Open();
                docenteRepository.Agregar(docente);

                return $"Los datos del Docente {docente.Nombre} se han registrado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al registrar docente: " + e.Message.ToString();


            }
            finally
            {

                conexionRepository.Close();


            }

            return null;


        }

        public Docente ConsultarId(string identificacion)
        {
            try
            {

                conexionRepository.Open();
                docente = new Docente();
                docente = docenteRepository.ConsultarId(identificacion);
                return docente;

            }
            catch (Exception e)
            {
                string msg = $"Error al modificar docente: " + e.Message.ToString();

            }
            finally
            {

                conexionRepository.Close();

            }

            return null;

        }

        public string Modificar(Docente docente)
        {
            try
            {

                conexionRepository.Open();
                docenteRepository.Modificar(docente);
                return "Docente modificado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al modificar docente: " + e.Message.ToString();

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
                docenteRepository.Eliminar(identificacion);
                return "Docente Eliminado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al eliminar Docente: " + e.Message.ToString();

            }
            finally
            {

                conexionRepository.Close();

            }

            return null;



        }

        public List<Docente> BuscarCaracter(string caracter)
        {

            try
            {
                conexionRepository.Open();
                return docenteRepository.BuscarCaracter(caracter);

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
