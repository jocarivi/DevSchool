using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
 

namespace ProyectDevSchool
{
    public partial class FrmResgitroEstudiante : Form
    {

        public FrmResgitroEstudiante()
        {
            InitializeComponent();
        }

        private void FrmResgitro_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            EstudiantesService estudiantesService = new EstudiantesService(ConfigConnection.connectionString);
            dgt_estudiantes.DataSource = estudiantesService.Consultar();
            MessageBox.Show("SE EJECUTA").ToString();
        }

        private void dtg_estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
