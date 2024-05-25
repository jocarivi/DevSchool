using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectDevSchool
{
    public partial class FrmMatricula : Form
    {
        MatriculaService matriculaService;
        GradoService gradoService;
        EstudiantesService estudiantesService;
       
        
        
        public FrmMatricula()
        {
            InitializeComponent();
            matriculaService = new MatriculaService(ConfigConnection.connectionString);
            estudiantesService= new EstudiantesService(ConfigConnection.connectionString);  
            dtgMatricula.DataSource = matriculaService.Consultar();
        }

        public void CargarComboGrados()
        {
            gradoService = new GradoService(ConfigConnection.connectionString);
            List<Grado> grados = gradoService.Consultar();

            List<Grado> listaGradoFiltro = new List<Grado>();
            {
                listaGradoFiltro.Add(new Grado { id = 0, grado = "SELECCIONE" });
            };

            listaGradoFiltro.AddRange(grados);

            cmb_grados.DataSource = listaGradoFiltro;
            cmb_grados.ValueMember = "id";
            cmb_grados.DisplayMember = "grado";

            cmb_grados.SelectedIndex = 0;



        }

        public void CargarComboFiltro()
        {
            gradoService = new GradoService(ConfigConnection.connectionString);
            List<Grado> grados =gradoService.Consultar();

            List<Grado> listaGradoFiltro = new List<Grado>();
            {
                listaGradoFiltro.Add( new Grado { id = 0, grado = "SELECCIONE" });
            };

            listaGradoFiltro.AddRange(grados);

            cmbfiltro.DataSource = listaGradoFiltro;
            cmbfiltro.ValueMember = "id";
            cmbfiltro.DisplayMember = "grado";

            cmbfiltro.SelectedIndex = 0;


        }



        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            CargarComboGrados();
            CargarComboFiltro();
        }

        private void btn_buscarid_Click(object sender, EventArgs e)
        {
            string identificacion = txt_id.Text;
            if (identificacion != "")
            {
                Estudiantes estudiante = estudiantesService.ConsultarId(identificacion);
                if (estudiante != null)
                {
                    txt_nombre1.Text = estudiante.Nombre;
                    txt_nombre2.Text = estudiante.Nombre2;
                    txt_apellido1.Text = estudiante.Apellido1;
                    txt_apellido2.Text = estudiante.Apellido2;                    
                    txt_promedio.Text = estudiante.Promedio_actual.ToString();

                }else
                {
                    MessageBox.Show("Estudiante no encontrado");
                }


            }

        }

        public void Limpiar()
        {
            txt_id.Clear();
            txt_nombre1.Clear();
            txt_nombre2.Clear();
            txt_apellido1.Clear();
            txt_apellido2.Clear();
            txt_promedio.Clear();
            //cmb_grados.Text ="SELECCIONE";
            cmb_grados.SelectedIndex = 0;
        }


        private void btn_asignar_Click(object sender, EventArgs e)
        {
            string busquedaEstudiante;
            busquedaEstudiante = txt_id.Text;
            try
            {
                if (cmb_grados.Text == "SELECCIONE") {
                    MessageBox.Show("SELECCIONE GRADO A MATRICULAR");
                }
                else if(busquedaEstudiante!=""){
                   var busqueda = estudiantesService.BuscarCaracterExacto(busquedaEstudiante);
                    if (busqueda == null)
                    {
                        //registro de estudiante aun sin validar los campos
                        Matricula matricula = new Matricula();
                        matricula.GradoId = Convert.ToInt32(cmb_grados.SelectedValue);
                        matricula.EstudianteID = txt_id.Text;

                        string mensaje = matriculaService.Agregar(matricula);

                        matriculaService = new MatriculaService(ConfigConnection.connectionString);
                        dtgMatricula.DataSource = matriculaService.Consultar();
                        Limpiar();
                    }
                    else {

                        MessageBox.Show("Estudiante a matricular no existe");
                    
                    }


                }


            }

            catch (Exception ex)
            {

                MessageBox.Show("Verifique los datos digitados :" + ex.Message, "Resultado de agregar ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }

        private void cmbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfiltro.Text == "SELECCIONE") {

                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatricula.DataSource = matriculaService.Consultar();

            }else
            {

                string filtroCombo = cmbfiltro.Text;

                matriculaService = new MatriculaService(ConfigConnection.connectionString);
                dtgMatricula.DataSource = matriculaService.BuscarCaracter(filtroCombo);

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbfiltro.SelectedIndex = 0;

        }
    }
}
