using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class EspecialidadService
    {
        private ConexionRepository conexionRepository;
        private EspecialidadRepository especialidadRepository;

        List<Especialidad> especialidades;
        Especialidad especialidad;


        public EspecialidadService(string conexion)
        {

            conexionRepository = new ConexionRepository(conexion);
            especialidadRepository = new EspecialidadRepository(conexionRepository);

        }


        public EspecialidadService() { }

        public List<Especialidad> Consultar()
        {

            try
            {
                especialidades = new List<Especialidad>();
                conexionRepository.Open();
                especialidades = especialidadRepository.Consultar();
                return especialidades;

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


        public string Agregar(Especialidad especialidad)
        {


            try
            {

                conexionRepository.Open();
                especialidadRepository.Agregar(especialidad);

                return $"La especialidad {especialidad.especialidad} se han registrado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al registrar especialidad: " + e.Message.ToString();


            }
            finally
            {

                conexionRepository.Close();


            }

            return null;


        }


        public Especialidad ConsultarId(string identificacion)
        {
            try
            {

                conexionRepository.Open();
                especialidad = new Especialidad();
                especialidad = especialidadRepository.ConsultarId(identificacion);
                return especialidad;

            }
            catch (Exception e)
            {
                string msg = $"Error al modificar especialidad: " + e.Message.ToString();

            }
            finally
            {

                conexionRepository.Close();

            }

            return null;

        }

        public string Modificar(Especialidad especialidad)
        {
            try
            {

                conexionRepository.Open();
                especialidadRepository.Modificar(especialidad);
                return "Especialidad modificada correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al modificar Especialidad: " + e.Message.ToString();

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
                especialidadRepository.Eliminar(identificacion);
                return "Especialidad Eliminado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al eliminar Especialidad: " + e.Message.ToString();

            }
            finally
            {

                conexionRepository.Close();

            }

            return null;



        }


        public List<Especialidad> BuscarCaracter(string caracter)
        {

            try
            {
                conexionRepository.Open();
                return especialidadRepository.BuscarCaracter(caracter);

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

