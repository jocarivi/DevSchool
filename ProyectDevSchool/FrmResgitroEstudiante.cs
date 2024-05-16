﻿using System;
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
            dgt_estudiantes.DataSource = estudiantesService.Consultar();
        }

        
        private void FrmResgitro_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                estudiantesService = new EstudiantesService(ConfigConnection.connectionString);
                dgt_estudiantes.DataSource = estudiantesService.Consultar();

            }
            else if (txt_id.Text != "")
            {
                string identificacion = txt_id.Text;
                Estudiantes estudiante = estudiantesService.ConsultarId(identificacion);
                if (estudiante != null)
                {
                    
                    txt_nombre1.Text = estudiante.Nombre;
                    txt_nombre2.Text= estudiante.Nombre2;
                    txt_apelldio1.Text = estudiante.Apellido1;
                    txt_apellido2.Text= estudiante.Apellido2;
                    txt_direecion.Text = estudiante.Direccion;
                    txt_correo.Text = estudiante.Mail.Address;
                    dtp_fechaNacimiento.Text = estudiante.Fecha_Nacimiento.ToString();
                    txt_telefono.Text = estudiante.Telefono;
                    lbl_promedio.Text = estudiante.Promedio_actual.ToString();

                }
                else {

                    MessageBox.Show("Estudiante no encontrado");
                
                }
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
                dgt_estudiantes.DataSource = estudiantesService.Consultar();
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
                    dgt_estudiantes.DataSource = estudiantesService.Consultar();
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
    }
}
