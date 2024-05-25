namespace ProyectDevSchool
{
    partial class FrmMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_grado = new System.Windows.Forms.Label();
            this.cmb_grados = new System.Windows.Forms.ComboBox();
            this.lbl_identificacion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_nombre2 = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_apellido2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.txt_nombre2 = new System.Windows.Forms.TextBox();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.dtgMatricula = new System.Windows.Forms.DataGridView();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_promedio = new System.Windows.Forms.Label();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.btn_buscarid = new System.Windows.Forms.Button();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.cmbfiltro = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(324, 9);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(435, 54);
            this.lbl_matricula.TabIndex = 0;
            this.lbl_matricula.Text = "MATRICULA ESCOLAR";
            // 
            // lbl_grado
            // 
            this.lbl_grado.AutoSize = true;
            this.lbl_grado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grado.Location = new System.Drawing.Point(328, 106);
            this.lbl_grado.Name = "lbl_grado";
            this.lbl_grado.Size = new System.Drawing.Size(74, 25);
            this.lbl_grado.TabIndex = 1;
            this.lbl_grado.Text = "GRADO";
            // 
            // cmb_grados
            // 
            this.cmb_grados.FormattingEnabled = true;
            this.cmb_grados.Location = new System.Drawing.Point(333, 134);
            this.cmb_grados.Name = "cmb_grados";
            this.cmb_grados.Size = new System.Drawing.Size(163, 28);
            this.cmb_grados.TabIndex = 2;
            // 
            // lbl_identificacion
            // 
            this.lbl_identificacion.AutoSize = true;
            this.lbl_identificacion.Location = new System.Drawing.Point(329, 196);
            this.lbl_identificacion.Name = "lbl_identificacion";
            this.lbl_identificacion.Size = new System.Drawing.Size(138, 20);
            this.lbl_identificacion.TabIndex = 3;
            this.lbl_identificacion.Text = "IDENTIFICACION";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(329, 252);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(146, 20);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "PRIMER NOMBRE";
            // 
            // lbl_nombre2
            // 
            this.lbl_nombre2.AutoSize = true;
            this.lbl_nombre2.Location = new System.Drawing.Point(329, 305);
            this.lbl_nombre2.Name = "lbl_nombre2";
            this.lbl_nombre2.Size = new System.Drawing.Size(165, 20);
            this.lbl_nombre2.TabIndex = 5;
            this.lbl_nombre2.Text = "SEGUNDO NOMBRE";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(329, 363);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(155, 20);
            this.lbl_apellido.TabIndex = 6;
            this.lbl_apellido.Text = "PRIMER APELLIDO";
            // 
            // lbl_apellido2
            // 
            this.lbl_apellido2.AutoSize = true;
            this.lbl_apellido2.Location = new System.Drawing.Point(329, 419);
            this.lbl_apellido2.Name = "lbl_apellido2";
            this.lbl_apellido2.Size = new System.Drawing.Size(174, 20);
            this.lbl_apellido2.TabIndex = 7;
            this.lbl_apellido2.Text = "SEGUNDO APELLIDO";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(526, 190);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(190, 26);
            this.txt_id.TabIndex = 8;
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Enabled = false;
            this.txt_nombre1.Location = new System.Drawing.Point(526, 246);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(190, 26);
            this.txt_nombre1.TabIndex = 9;
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.Enabled = false;
            this.txt_nombre2.Location = new System.Drawing.Point(526, 299);
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(190, 26);
            this.txt_nombre2.TabIndex = 10;
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Enabled = false;
            this.txt_apellido1.Location = new System.Drawing.Point(526, 357);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(190, 26);
            this.txt_apellido1.TabIndex = 11;
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Enabled = false;
            this.txt_apellido2.Location = new System.Drawing.Point(526, 413);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(190, 26);
            this.txt_apellido2.TabIndex = 12;
            // 
            // dtgMatricula
            // 
            this.dtgMatricula.BackgroundColor = System.Drawing.Color.Gray;
            this.dtgMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMatricula.GridColor = System.Drawing.Color.Black;
            this.dtgMatricula.Location = new System.Drawing.Point(41, 660);
            this.dtgMatricula.Name = "dtgMatricula";
            this.dtgMatricula.RowHeadersWidth = 62;
            this.dtgMatricula.RowTemplate.Height = 28;
            this.dtgMatricula.Size = new System.Drawing.Size(933, 305);
            this.dtgMatricula.TabIndex = 13;
            // 
            // btn_asignar
            // 
            this.btn_asignar.Location = new System.Drawing.Point(395, 988);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(108, 31);
            this.btn_asignar.TabIndex = 14;
            this.btn_asignar.Text = "ASIGNAR";
            this.btn_asignar.UseVisualStyleBackColor = true;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(528, 988);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(108, 31);
            this.btn_buscar.TabIndex = 15;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // lbl_promedio
            // 
            this.lbl_promedio.AutoSize = true;
            this.lbl_promedio.Location = new System.Drawing.Point(329, 467);
            this.lbl_promedio.Name = "lbl_promedio";
            this.lbl_promedio.Size = new System.Drawing.Size(96, 20);
            this.lbl_promedio.TabIndex = 16;
            this.lbl_promedio.Text = "PROMEDIO";
            // 
            // txt_promedio
            // 
            this.txt_promedio.Enabled = false;
            this.txt_promedio.Location = new System.Drawing.Point(526, 467);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.Size = new System.Drawing.Size(190, 26);
            this.txt_promedio.TabIndex = 17;
            // 
            // btn_buscarid
            // 
            this.btn_buscarid.Location = new System.Drawing.Point(738, 184);
            this.btn_buscarid.Name = "btn_buscarid";
            this.btn_buscarid.Size = new System.Drawing.Size(89, 32);
            this.btn_buscarid.TabIndex = 18;
            this.btn_buscarid.Text = "BUSCAR";
            this.btn_buscarid.UseVisualStyleBackColor = true;
            this.btn_buscarid.Click += new System.EventHandler(this.btn_buscarid_Click);
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Location = new System.Drawing.Point(37, 590);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(179, 20);
            this.lbl_filtro.TabIndex = 19;
            this.lbl_filtro.Text = "FILTRAR POR GRADO";
            // 
            // cmbfiltro
            // 
            this.cmbfiltro.FormattingEnabled = true;
            this.cmbfiltro.Location = new System.Drawing.Point(222, 590);
            this.cmbfiltro.Name = "cmbfiltro";
            this.cmbfiltro.Size = new System.Drawing.Size(163, 28);
            this.cmbfiltro.TabIndex = 20;
            this.cmbfiltro.SelectedIndexChanged += new System.EventHandler(this.cmbfiltro_SelectedIndexChanged);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(651, 988);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(108, 31);
            this.btn_limpiar.TabIndex = 21;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1182, 1052);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.cmbfiltro);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.btn_buscarid);
            this.Controls.Add(this.txt_promedio);
            this.Controls.Add(this.lbl_promedio);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.dtgMatricula);
            this.Controls.Add(this.txt_apellido2);
            this.Controls.Add(this.txt_apellido1);
            this.Controls.Add(this.txt_nombre2);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_apellido2);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre2);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_identificacion);
            this.Controls.Add(this.cmb_grados);
            this.Controls.Add(this.lbl_grado);
            this.Controls.Add(this.lbl_matricula);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMatricula";
            this.Text = "FrmGrados";
            this.Load += new System.EventHandler(this.FrmMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_grado;
        private System.Windows.Forms.ComboBox cmb_grados;
        private System.Windows.Forms.Label lbl_identificacion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_nombre2;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_apellido2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.DataGridView dtgMatricula;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_promedio;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.Button btn_buscarid;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.ComboBox cmbfiltro;
        private System.Windows.Forms.Button btn_limpiar;
    }
}