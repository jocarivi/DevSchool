
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using ENTITY;

namespace BLL
{
    public class EstudiantesService 
    {
        private ConexionRepository conexionRepository;
        private EstudiantesRepository estudiantesRepository;

        List<Estudiantes> estudiantes;
        Estudiantes estudiante;

     

        public EstudiantesService(string conexion) {
        
            conexionRepository =  new ConexionRepository(conexion);
            estudiantesRepository = new EstudiantesRepository(conexionRepository);

        }

        public EstudiantesService() { }

        public List<Estudiantes> Consultar()
        {

            try {
                estudiantes = new List<Estudiantes>();
                conexionRepository.Open();
                estudiantes = estudiantesRepository.Consultar();
                return estudiantes;
                    
                    } catch (Exception e){ 
                    
                string msg =$"Error: "+ e.Message.ToString();

            
            } finally { 

                conexionRepository.Close(); 
            
            
            }

            return null;
        
        }


        public string Agregar(Estudiantes estudiante) {


            try
            {
                
                conexionRepository.Open();
                estudiantesRepository.Agregar(estudiante);

                return $"Los datos del estudiante {estudiante.Nombre} se han registrado correctamente";

            }
            catch (Exception e)
            {

                string msg = $"Error al registrar estudiante: " + e.Message.ToString();


            }
            finally
            {

                conexionRepository.Close();


            }

            return null;


        }


        public Estudiantes ConsultarId(string identificacion)
        {
            try
            {

                conexionRepository.Open();
                estudiante = new Estudiantes();
                estudiante = estudiantesRepository.ConsultarId(identificacion);
                return estudiante;

            }
            catch (Exception e)
            {
                string msg = $"Error al modificar estudiante: " + e.Message.ToString();

            }
            finally { 
            
                conexionRepository.Close() ;
            
            }

            return null;

        }

        public string Modificar(Estudiantes estudiante)
        {
            try { 
            
                conexionRepository.Open();
                estudiantesRepository.Modificar(estudiante);
                return "Estudiante modificado correctamente";
            
            } catch (Exception e) {

                string msg = $"Error al modificar estudiante: " + e.Message.ToString();

            } finally {

                conexionRepository.Close();
            
            }

            return null;
        
        }

       


    }
}
