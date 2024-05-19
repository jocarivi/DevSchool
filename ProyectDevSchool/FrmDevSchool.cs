using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectDevSchool
{
    public partial class FrmDevSchool : Form
    {

        FrmInicio frmInicio;
        FrmResgitroDocente frmRegistroDocente;
        FrmResgitroEstudiante frmResgitroEstudiante;
        FrmRegistroEspecialiad frmRegistroEspecialiad;

        public FrmDevSchool()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         
            this.WindowState= FormWindowState.Maximized;
         
            
        }

        bool menuExpandido = false;

        private void TransicionMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido == false)
            {

                panel_usuarios.Height += 10;

                if (panel_usuarios.Height >= 247)
                {

                    TransicionMenu.Stop();
                    menuExpandido = true;

                }

            }
            else { 
            
                panel_usuarios.Height -= 10;
                if (panel_usuarios.Height <=64 ) {

                    TransicionMenu.Stop();
                    menuExpandido = false;
                               
                }
            
            }

        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            TransicionMenu.Start();
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_barra_Click(object sender, EventArgs e)
        {
            BarraTransicion.Start();
        }

        bool barraExpandida = true;
        private void BarraTransicion_Tick(object sender, EventArgs e)
        {
            if (barraExpandida)
            {

                Barra.Width -= 5;
                if (Barra.Width <= 65)
                {

                    barraExpandida = false;
                    BarraTransicion.Stop();

                }

            }
            else
            {

                Barra.Width += 5;

                if (Barra.Width >= 319)
                {

                    barraExpandida = true;
                    BarraTransicion.Stop();
                }

            }
        }

        private void bnt_inicio_Click(object sender, EventArgs e)
        {
            if (frmInicio == null)
            {

                frmInicio = new FrmInicio();
                frmInicio.FormClosed += FrmInicio_FormClosed;
                frmInicio.MdiParent = this;
                frmInicio.Dock = DockStyle.Fill;    
                frmInicio.Show();

            }
            else
            {
                frmInicio.Activate();
            }
        }


        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmDevSchool_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_docente_Click(object sender, EventArgs e)
        {
            if (frmRegistroDocente == null)
            {

                frmRegistroDocente = new FrmResgitroDocente();
                frmRegistroDocente.FormClosed += FrmRegistroDocente_FormClosed;
                frmRegistroDocente.MdiParent = this;
                frmRegistroDocente.Dock = DockStyle.Fill;
                frmRegistroDocente.Show();

            }
            else {
                frmRegistroDocente?.Activate();    
            }
        }

        private void FrmRegistroDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();  
        }

        private void FrmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmRegistroDocente = null;

        }

        private void btn_estudiante_Click(object sender, EventArgs e)
        {
            try {
                if (frmResgitroEstudiante == null)
                {

                    frmResgitroEstudiante = new FrmResgitroEstudiante();
                    frmResgitroEstudiante.FormClosed += FrmResgitroEstudiante_FormClosed;
                    frmResgitroEstudiante.MdiParent = this;
                    frmResgitroEstudiante.Dock = DockStyle.Fill;
                    frmResgitroEstudiante.Show();

                }
                else
                {
                    frmResgitroEstudiante.Activate();
                }
            } catch(Exception ex){

                MessageBox.Show("Error: "+ ex.Message);
            
            }
          

        }

        private void FrmResgitroEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmRegistroEspecialiad == null)
                {

                    frmRegistroEspecialiad = new FrmRegistroEspecialiad();
                    frmRegistroEspecialiad.FormClosed += FrmRegistroEspecialidad_FormClosed;
                    frmRegistroEspecialiad.MdiParent = this;
                    frmRegistroEspecialiad.Dock = DockStyle.Fill;
                    frmRegistroEspecialiad.Show();

                }
                else
                {
                    frmRegistroEspecialiad.Activate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void FrmRegistroEspecialidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
