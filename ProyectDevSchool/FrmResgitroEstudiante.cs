using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;


namespace ProyectDevSchool
{
    public partial class FrmResgitroEstudiante : Form
    {
        EstudiantesService estudiantesService;

    

        public FrmResgitroEstudiante()
        {
            InitializeComponent();
            txt_id.Focus();
            estudiantesService = new EstudiantesService(ConfigConnection.connectionString);
           dgtEstudiantes.DataSource = estudiantesService.Consultar();
            

        }

        
        private void FrmResgitro_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

            try
            {
                estudiantesService = new EstudiantesService(ConfigConnection.connectionString);
                dgtEstudiantes.DataSource = estudiantesService.Consultar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar datos" + ex.Message);

            }

        }

        private void dtg_estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            try { 
                //registro de estudiante aun sin validar los campos
                Estudiantes estudiante = new Estudiantes();    
                estudiante.Id_dni = txt_id.Text;
                estudiante.Nombre = txt_nombre1.Text;
                estudiante.Nombre2 = txt_nombre2.Text;
                estudiante.Apellido1 = txt_apelldio1.Text;
                estudiante.Apellido2  = txt_apellido2.Text;
                estudiante.Direccion = txt_direecion.Text;
                estudiante.Mail = new MailAddress(txt_correo.Text.Trim());
                estudiante.Fecha_Nacimiento = dtp_fechaNacimiento.Text;
                estudiante.Telefono = txt_telefono.Text;
                estudiante.Promedio_actual = 0;
                string mensaje = estudiantesService.Agregar(estudiante);
                MessageBox.Show(mensaje,"Estudiante registrado :" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                estudiantesService = new EstudiantesService(ConfigConnection.connectionString);
                dgtEstudiantes.DataSource = estudiantesService.Consultar();
                Limpiar();

            } catch(Exception ex) {

                MessageBox.Show("Verifique los datos digitados :" + ex.Message, "Resultado de agregar ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            }

        }

        public void Limpiar()
        {
            txt_id.Text = "";
            txt_nombre1.Text = "";
            txt_nombre2.Text = "";
            txt_apelldio1.Text = "";
            txt_apellido2.Text = "";
            txt_direecion.Text = "";
            txt_correo.Text = "";
            dtp_fechaNacimiento.Text = DateTime.Now.ToString();
            txt_telefono.Text = "";


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string identificacion = txt_id.Text;
            if (identificacion != "")
            {
                Estudiantes estudiante = estudiantesService.ConsultarId(identificacion);
                if (estudiante != null)
                {
                    estudiante.Nombre = txt_nombre1.Text;
                    estudiante.Nombre2 = txt_nombre2.Text;
                    estudiante.Apellido1 = txt_apelldio1.Text;
                    estudiante.Apellido2 = txt_apellido2.Text;
                    estudiante.Direccion = txt_direecion.Text;
                    estudiante.Mail = new MailAddress(txt_correo.Text.Trim());
                    estudiante.Fecha_Nacimiento = dtp_fechaNacimiento.Text;
                    estudiante.Telefono = txt_telefono.Text;
                    estudiante.Promedio_actual = Convert.ToDecimal(lbl_promedio.Text);
                    var respuesta = MessageBox.Show("¿Desea continuar con esta acción? ", " ", MessageBoxButtons.OKCancel);
                    if (respuesta == DialogResult.OK) {

                        string msj = estudiantesService.Modificar(estudiante);
                        MessageBox.Show(msj, "Estudiante Modificado :" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();

                    }
                }


            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txt_id.Text;

            if (identificacion != "")
            {
                Estudiantes estudiante = estudiantesService.ConsultarId(identificacion);
                var respuesta = MessageBox.Show("¿Desea continuar con esta acción? ", " ", MessageBoxButtons.OKCancel);
                if (respuesta == DialogResult.OK)
                {
                    string mensaje = estudiantesService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Estudiante Eliminado :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estudiantesService = new EstudiantesService(ConfigConnection.connectionString);
                    dgtEstudiantes.DataSource = estudiantesService.Consultar();
                    Limpiar();


                }
                else
                {

                    MessageBox.Show("Estudiante no encontrado para realizar la acción");

                }


            }
            else {

                MessageBox.Show("Digite la identificación");

            }


            

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

            string filtroId = txt_id.Text;           
              
                    estudiantesService = new EstudiantesService(ConfigConnection.connectionString);
                    dgtEstudiantes.DataSource = estudiantesService.BuscarCaracter(filtroId);                 
                    
        }

        private void dgt_estudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgtEstudiantes.CurrentRow.Cells[2].Value.ToString();
            txt_nombre1.Text = dgtEstudiantes.CurrentRow.Cells[3].Value.ToString(); 
            txt_nombre2.Text = dgtEstudiantes.CurrentRow.Cells[4].Value.ToString(); 
            txt_apelldio1.Text = dgtEstudiantes.CurrentRow.Cells[5].Value.ToString(); 
            txt_apellido2.Text = dgtEstudiantes.CurrentRow.Cells[6].Value.ToString(); 
            txt_direecion.Text = dgtEstudiantes.CurrentRow.Cells[7].Value.ToString();                          
            txt_telefono.Text = dgtEstudiantes.CurrentRow.Cells[8].Value.ToString();
            dtp_fechaNacimiento.Text = dgtEstudiantes.CurrentRow.Cells[9].Value.ToString();
            txt_correo.Text = dgtEstudiantes.CurrentRow.Cells[10].Value.ToString();
            lbl_promedio.Text = dgtEstudiantes.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txt_nombre1_TextChanged(object sender, EventArgs e)
        {
            string filtroNombre = txt_nombre1.Text;

                    estudiantesService = new EstudiantesService(ConfigConnection.connectionString);
                    dgtEstudiantes.DataSource = estudiantesService.BuscarCaracter(filtroNombre);
         
        }
    }
}
