﻿namespace ProyectDevSchool
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
            this.dgtEstudiantes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_promedio = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "GETION DE ESTUDIANTE";
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
            this.txt_nombre1.TextChanged += new System.EventHandler(this.txt_nombre1_TextChanged);
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
            this.txt_apelldio1.Location = new System.Drawing.Point(746, 128);
            this.txt_apelldio1.Name = "txt_apelldio1";
            this.txt_apelldio1.Size = new System.Drawing.Size(156, 26);
            this.txt_apelldio1.TabIndex = 7;
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(968, 128);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(156, 26);
            this.txt_apellido2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "IDENTIFICACION";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(100, 128);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(156, 26);
            this.txt_id.TabIndex = 10;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
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
            this.lbl_direccion.Location = new System.Drawing.Point(100, 218);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(99, 20);
            this.lbl_direccion.TabIndex = 11;
            this.lbl_direccion.Text = "DIRECCION";
            // 
            // txt_direecion
            // 
            this.txt_direecion.Location = new System.Drawing.Point(100, 251);
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
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(746, 249);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(184, 26);
            this.dtp_fechaNacimiento.TabIndex = 17;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(204, 532);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(112, 35);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(388, 532);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(112, 35);
            this.btn_consultar.TabIndex = 20;
            this.btn_consultar.Text = "BUSCAR";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(572, 532);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(112, 35);
            this.btn_modificar.TabIndex = 21;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(759, 532);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(112, 35);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(524, 251);
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
            // dgtEstudiantes
            // 
            this.dgtEstudiantes.BackgroundColor = System.Drawing.Color.Gray;
            this.dgtEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtEstudiantes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgtEstudiantes.GridColor = System.Drawing.Color.Black;
            this.dgtEstudiantes.Location = new System.Drawing.Point(34, 308);
            this.dgtEstudiantes.Name = "dgtEstudiantes";
            this.dgtEstudiantes.RowHeadersWidth = 62;
            this.dgtEstudiantes.RowTemplate.Height = 28;
            this.dgtEstudiantes.Size = new System.Drawing.Size(1174, 171);
            this.dgtEstudiantes.TabIndex = 25;
            this.dgtEstudiantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgt_estudiantes_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1000, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "PROMEDIO";
            // 
            // lbl_promedio
            // 
            this.lbl_promedio.AutoSize = true;
            this.lbl_promedio.Location = new System.Drawing.Point(1032, 249);
            this.lbl_promedio.Name = "lbl_promedio";
            this.lbl_promedio.Size = new System.Drawing.Size(31, 20);
            this.lbl_promedio.TabIndex = 27;
            this.lbl_promedio.Text = "0.0";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(926, 532);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(112, 35);
            this.btn_limpiar.TabIndex = 28;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // FrmResgitroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1239, 608);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_promedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgtEstudiantes);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResgitroEstudiante";
            this.Text = "FrmResgistroEstudiante";
            this.Load += new System.EventHandler(this.FrmResgitro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtEstudiantes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgtEstudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_promedio;
        private System.Windows.Forms.Button btn_limpiar;
    }
}