namespace ProyectDevSchool
{
    partial class FrmResgitroEstudiante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido2 = new System.Windows.Forms.Label();
            this.lbl_apellido1 = new System.Windows.Forms.Label();
            this.lbl_nombre2 = new System.Windows.Forms.Label();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.txt_nombre2 = new System.Windows.Forms.TextBox();
            this.txt_apelldio1 = new System.Windows.Forms.TextBox();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direecion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.dgt_estudiantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_estudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO  ESTUDIANTE";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(310, 98);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(146, 20);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "PRIMER NOMBRE";
            // 
            // lbl_apellido2
            // 
            this.lbl_apellido2.AutoSize = true;
            this.lbl_apellido2.Location = new System.Drawing.Point(963, 98);
            this.lbl_apellido2.Name = "lbl_apellido2";
            this.lbl_apellido2.Size = new System.Drawing.Size(174, 20);
            this.lbl_apellido2.TabIndex = 2;
            this.lbl_apellido2.Text = "SEGUNDO APELLIDO";
            // 
            // lbl_apellido1
            // 
            this.lbl_apellido1.AutoSize = true;
            this.lbl_apellido1.Location = new System.Drawing.Point(741, 98);
            this.lbl_apellido1.Name = "lbl_apellido1";
            this.lbl_apellido1.Size = new System.Drawing.Size(155, 20);
            this.lbl_apellido1.TabIndex = 3;
            this.lbl_apellido1.Text = "PRIMER APELLIDO";
            // 
            // lbl_nombre2
            // 
            this.lbl_nombre2.AutoSize = true;
            this.lbl_nombre2.Location = new System.Drawing.Point(524, 98);
            this.lbl_nombre2.Name = "lbl_nombre2";
            this.lbl_nombre2.Size = new System.Drawing.Size(165, 20);
            this.lbl_nombre2.TabIndex = 4;
            this.lbl_nombre2.Text = "SEGUNDO NOMBRE";
            // 
            // txt_nombre1
            // 
            this.txt_nombre1.Location = new System.Drawing.Point(314, 128);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(156, 26);
            this.txt_nombre1.TabIndex = 5;
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.Location = new System.Drawing.Point(528, 128);
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(156, 26);
            this.txt_nombre2.TabIndex = 6;
            // 
            // txt_apelldio1
            // 
            this.txt_apelldio1.Location = new System.Drawing.Point(745, 128);
            this.txt_apelldio1.Name = "txt_apelldio1";
            this.txt_apelldio1.Size = new System.Drawing.Size(156, 26);
            this.txt_apelldio1.TabIndex = 7;
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(967, 128);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(156, 26);
            this.txt_apellido2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "IDENTIFICACION";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(101, 128);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(156, 26);
            this.txt_id.TabIndex = 10;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(315, 218);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(94, 20);
            this.lbl_telefono.TabIndex = 13;
            this.lbl_telefono.Text = "TELEFONO";
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.AutoSize = true;
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(741, 218);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(194, 20);
            this.lbl_fechaNacimiento.TabIndex = 12;
            this.lbl_fechaNacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(101, 218);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(99, 20);
            this.lbl_direccion.TabIndex = 11;
            this.lbl_direccion.Text = "DIRECCION";
            // 
            // txt_direecion
            // 
            this.txt_direecion.Location = new System.Drawing.Point(101, 251);
            this.txt_direecion.Name = "txt_direecion";
            this.txt_direecion.Size = new System.Drawing.Size(156, 26);
            this.txt_direecion.TabIndex = 16;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(314, 251);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(156, 26);
            this.txt_telefono.TabIndex = 14;
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(745, 249);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(184, 26);
            this.dtp_fechaNacimiento.TabIndex = 17;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(262, 533);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(112, 35);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(446, 533);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(112, 35);
            this.btn_consultar.TabIndex = 20;
            this.btn_consultar.Text = "BUSCAR";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(630, 533);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(112, 35);
            this.btn_modificar.TabIndex = 21;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(817, 533);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(112, 35);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(523, 251);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(156, 26);
            this.txt_correo.TabIndex = 24;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(524, 218);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(79, 20);
            this.lbl_correo.TabIndex = 23;
            this.lbl_correo.Text = "CORREO";
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Controls.Add(this.dataRepeater1.ItemTemplate);
            this.dataRepeater1.Location = new System.Drawing.Point(0, 0);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(240, 150);
            this.dataRepeater1.TabIndex = 0;
            // 
            // dgt_estudiantes
            // 
            this.dgt_estudiantes.BackgroundColor = System.Drawing.Color.White;
            this.dgt_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgt_estudiantes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgt_estudiantes.GridColor = System.Drawing.Color.Gray;
            this.dgt_estudiantes.Location = new System.Drawing.Point(115, 308);
            this.dgt_estudiantes.Name = "dgt_estudiantes";
            this.dgt_estudiantes.RowHeadersWidth = 62;
            this.dgt_estudiantes.RowTemplate.Height = 28;
            this.dgt_estudiantes.Size = new System.Drawing.Size(996, 107);
            this.dgt_estudiantes.TabIndex = 25;
            // 
            // FrmResgitroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(817, 405);
            this.Controls.Add(this.dgt_estudiantes);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.txt_direecion);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_fechaNacimiento);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_apellido2);
            this.Controls.Add(this.txt_apelldio1);
            this.Controls.Add(this.txt_nombre2);
            this.Controls.Add(this.txt_nombre1);
            this.Controls.Add(this.lbl_nombre2);
            this.Controls.Add(this.lbl_apellido1);
            this.Controls.Add(this.lbl_apellido2);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResgitroEstudiante";
            this.Text = "FrmResgistroEstudiante";
            this.Load += new System.EventHandler(this.FrmResgitro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_estudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido2;
        private System.Windows.Forms.Label lbl_apellido1;
        private System.Windows.Forms.Label lbl_nombre2;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.TextBox txt_apelldio1;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direecion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.DataGridView dgt_estudiantes;
    }
}