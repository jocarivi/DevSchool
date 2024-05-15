
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


    }
}
