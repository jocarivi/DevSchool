using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;
using System.Net.Mail;

namespace ProyectDevSchool
{
    public partial class FrmResgitroDocente : Form
    {
        DocenteService docenteService;


        public FrmResgitroDocente()
        {
            InitializeComponent();
            txtId.Focus();
            docenteService = new DocenteService(ConfigConnection.connectionString);
            dgtDocentes.DataSource = docenteService.Consultar();
        }

        private void FrmResgitro_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                docenteService = new DocenteService(ConfigConnection.connectionString);
                dgtDocentes.DataSource = docenteService.Consultar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar datos" + ex.Message);

            }
        }


        public void Limpiar()
        {
            txtId.Text = "";
            txt1Nombre.Text = "";
            txt2Nombre.Text = "";
            txt1Apellido.Text = "";
            txt2Apellido.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            dtp_fechaNacimiento.Text = DateTime.Now.ToString();
            txtTelefono.Text = "";
            txtEspecialidad.Text = "";


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string identificacion = txtId.Text;
            if (identificacion != "")
            {
                Docente docente = docenteService.ConsultarId(identificacion);
                if (docente != null)
                {
                    docente.Nombre = txt1Nombre.Text;
                    docente.Nombre2 = txt2Nombre.Text;
                    docente.Apellido1 = txt1Apellido.Text;
                    docente.Apellido2 = txt2Apellido.Text;
                    docente.Direccion = txtDireccion.Text;
                    docente.Mail = new MailAddress(txtCorreo.Text.Trim());
                    docente.Fecha_Nacimiento = dtp_fechaNacimiento.Text;
                    docente.Telefono = txtTelefono.Text;
                    docente.Especialidad = txtEspecialidad.Text;
                    
                    var respuesta = MessageBox.Show("¿Desea continuar con esta acción? ", " ", MessageBoxButtons.OKCancel);
                    if (respuesta == DialogResult.OK)
                    {

                        string msj = docenteService.Modificar(docente);
                        MessageBox.Show(msj, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();

                    }
                }


            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txtId.Text;

            if (identificacion != "")
            {
               Docente  docente = docenteService.ConsultarId(identificacion);
                var respuesta = MessageBox.Show("¿Desea continuar con esta acción? ", " ", MessageBoxButtons.OKCancel);
                if (respuesta == DialogResult.OK)
                {
                    string mensaje = docenteService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Docente Eliminado :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    docenteService = new DocenteService(ConfigConnection.connectionString);
                    dgtDocentes.DataSource = docenteService.Consultar();
                    Limpiar();


                }
                else
                {

                    MessageBox.Show("Docente no encontrado para realizar la acción");

                }


            }
            else
            {

                MessageBox.Show("Digite la identificación");

            }




        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            docenteService = new DocenteService(ConfigConnection.connectionString);
            string filtro = txtId.Text;
            dgtDocentes.DataSource = docenteService.BuscarCaracter(filtro);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txtId.Text;

            if (identificacion != "")
            {
                Docente docente = docenteService.ConsultarId(identificacion);
                var respuesta = MessageBox.Show("¿Desea continuar con esta acción? ", " ", MessageBoxButtons.OKCancel);
                if (respuesta == DialogResult.OK)
                {
                    string mensaje = docenteService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Docente Eliminado :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    docenteService = new DocenteService(ConfigConnection.connectionString);
                    dgtDocentes.DataSource = docenteService.Consultar();
                    Limpiar();


                }
                else
                {

                    MessageBox.Show("Docente no encontrado para realizar la acción");

                }


            }
            else
            {

                MessageBox.Show("Digite la identificación");

            }
        }

        private void dgtDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //registro de estudiante aun sin validar los campos
                Docente docente = new Docente();
                docente.Id_dni = txtId.Text;
                docente.Nombre = txt1Nombre.Text;
                docente.Nombre2 = txt2Nombre.Text;
                docente.Apellido1 = txt1Apellido.Text;
                docente.Apellido2 = txt2Apellido.Text;
                docente.Direccion = txtDireccion.Text;
                docente.Mail = new MailAddress(txtCorreo.Text.Trim());
                docente.Fecha_Nacimiento = dtp_fechaNacimiento.Text;
                docente.Telefono = txtTelefono.Text;
                docente.Especialidad = txtEspecialidad.Text;

                string mensaje = docenteService.Agregar(docente);
                MessageBox.Show(mensaje, "Docente registrado :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                docenteService = new DocenteService(ConfigConnection.connectionString);
                dgtDocentes.DataSource = docenteService.Consultar();
                Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifique los datos digitados :" + ex.Message, "Resultado de agregar ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
        }

        private void dgtDocentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgtDocentes.CurrentRow.Cells[2].Value.ToString();
            txt1Nombre.Text = dgtDocentes.CurrentRow.Cells[3].Value.ToString();
            txt2Nombre.Text = dgtDocentes.CurrentRow.Cells[4].Value.ToString();
            txt1Apellido.Text = dgtDocentes.CurrentRow.Cells[5].Value.ToString();
            txt2Apellido.Text = dgtDocentes.CurrentRow.Cells[6].Value.ToString();
            txtDireccion.Text = dgtDocentes.CurrentRow.Cells[7].Value.ToString();
            txtTelefono.Text = dgtDocentes.CurrentRow.Cells[8].Value.ToString();
            dtp_fechaNacimiento.Text = dgtDocentes.CurrentRow.Cells[9].Value.ToString();
            txtCorreo.Text = dgtDocentes.CurrentRow.Cells[10].Value.ToString();
            txtEspecialidad.Text = dgtDocentes.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
