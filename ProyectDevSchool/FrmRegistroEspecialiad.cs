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
using BLL;
using ENTITY;
using Syncfusion.Styles;

namespace ProyectDevSchool
{
    public partial class FrmRegistroEspecialiad : Form
    {
        string idmod;
        EspecialidadService especialidadService;
        public FrmRegistroEspecialiad()
        {
            InitializeComponent();
            especialidadService = new EspecialidadService(ConfigConnection.connectionString);
            dtg_especialidades.DataSource = especialidadService.Consultar();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                especialidadService = new EspecialidadService(ConfigConnection.connectionString);
                dtg_especialidades.DataSource = especialidadService.Consultar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar datos" + ex.Message);

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                //registro de estudiante aun sin validar los campos
                Especialidad especialidad = new Especialidad();
                especialidad.especialidad = txtEspecialidad.Text;
                string mensaje = especialidadService.Agregar(especialidad);
                MessageBox.Show(mensaje, "Especialidad registrads :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                especialidadService = new EspecialidadService(ConfigConnection.connectionString);
                dtg_especialidades.DataSource = especialidadService.Consultar();
                Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifique los datos digitados :" + ex.Message, "Resultado de agregar ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }

        public void Limpiar()
        {
            txtEspecialidad.Text = "";
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string identificacion = idmod;
            if (identificacion != "")
            {
                Especialidad especialidad = especialidadService.ConsultarId(identificacion);
                if (identificacion != null)
                {
                    especialidad.id = Convert.ToInt32(idmod);
                    especialidad.especialidad = txtEspecialidad.Text;
                    var respuesta = MessageBox.Show("¿Desea continuar con esta acción? ", " ", MessageBoxButtons.OKCancel);
                    if (respuesta == DialogResult.OK)
                    {

                        string msj = especialidadService.Modificar(especialidad);
                        MessageBox.Show(""+msj);
                        Limpiar();

                    }
                }


            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string identificacion = idmod;

            if (idmod != "")
            {
                Especialidad especialidad = especialidadService.ConsultarId(idmod);
                var respuesta = MessageBox.Show("¿Desea continuar con esta acción? ", " ", MessageBoxButtons.OKCancel);
                if (respuesta == DialogResult.OK)
                {
                    string mensaje = especialidadService.Eliminar(idmod);
                    MessageBox.Show(mensaje, "Especialidad Eliminada :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    especialidadService = new EspecialidadService(ConfigConnection.connectionString);
                    dtg_especialidades.DataSource = especialidadService.Consultar();
                    Limpiar();


                }
                else
                {

                    MessageBox.Show("Especialidad no encontrada para realizar la acción");

                }


            }
            else
            {

                MessageBox.Show("Digite el nombre de la especialidad");

            }
        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {
            //string filtro = txtEspecialidad.Text;

            //especialidadService = new EspecialidadService(ConfigConnection.connectionString);
            //dtg_especialidades.DataSource = especialidadService.BuscarCaracter(filtro);
        }
        
        private void dtg_especialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idmod = dtg_especialidades.CurrentRow.Cells[0].Value.ToString();
            txtEspecialidad.Text = dtg_especialidades.CurrentRow.Cells[1].Value.ToString();
            

        }

        private void FrmRegistroEspecialiad_Load(object sender, EventArgs e)
        {

        }
    }


}
