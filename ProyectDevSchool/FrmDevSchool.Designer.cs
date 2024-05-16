namespace ProyectDevSchool
{
    partial class FrmDevSchool
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevSchool));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pic_cerrar = new System.Windows.Forms.PictureBox();
            this.TransicionMenu = new System.Windows.Forms.Timer(this.components);
            this.BarraTransicion = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_barra = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_usuarios = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_docente = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_administrador = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_estudiante = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Barra = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_inicio = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bnt_inicio = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel_materias = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_reportes = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_salir = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_barra)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_usuarios.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Barra.SuspendLayout();
            this.panel_inicio.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel_materias.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_reportes.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_salir.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1147, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pic_cerrar
            // 
            this.pic_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("pic_cerrar.Image")));
            this.pic_cerrar.Location = new System.Drawing.Point(1249, 26);
            this.pic_cerrar.Name = "pic_cerrar";
            this.pic_cerrar.Size = new System.Drawing.Size(32, 32);
            this.pic_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_cerrar.TabIndex = 5;
            this.pic_cerrar.TabStop = false;
            this.pic_cerrar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TransicionMenu
            // 
            this.TransicionMenu.Interval = 10;
            this.TransicionMenu.Tick += new System.EventHandler(this.TransicionMenu_Tick);
            // 
            // BarraTransicion
            // 
            this.BarraTransicion.Interval = 10;
            this.BarraTransicion.Tick += new System.EventHandler(this.BarraTransicion_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "DevSchool";
            // 
            // btn_barra
            // 
            this.btn_barra.Image = ((System.Drawing.Image)(resources.GetObject("btn_barra.Image")));
            this.btn_barra.Location = new System.Drawing.Point(12, 9);
            this.btn_barra.Name = "btn_barra";
            this.btn_barra.Size = new System.Drawing.Size(60, 60);
            this.btn_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_barra.TabIndex = 0;
            this.btn_barra.TabStop = false;
            this.btn_barra.Click += new System.EventHandler(this.btn_barra_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_barra);
            this.panel1.Controls.Add(this.pic_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 119);
            this.panel1.TabIndex = 16;
            // 
            // panel_usuarios
            // 
            this.panel_usuarios.BackColor = System.Drawing.Color.Navy;
            this.panel_usuarios.Controls.Add(this.panel10);
            this.panel_usuarios.Controls.Add(this.panel14);
            this.panel_usuarios.Controls.Add(this.panel12);
            this.panel_usuarios.Controls.Add(this.panel3);
            this.panel_usuarios.Location = new System.Drawing.Point(0, 73);
            this.panel_usuarios.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel_usuarios.Name = "panel_usuarios";
            this.panel_usuarios.Size = new System.Drawing.Size(319, 226);
            this.panel_usuarios.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.button8);
            this.panel10.Location = new System.Drawing.Point(0, 64);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(319, 64);
            this.panel10.TabIndex = 14;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_docente);
            this.panel11.Location = new System.Drawing.Point(8, 8);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(319, 64);
            this.panel11.TabIndex = 12;
            // 
            // btn_docente
            // 
            this.btn_docente.BackColor = System.Drawing.Color.Blue;
            this.btn_docente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docente.Image = ((System.Drawing.Image)(resources.GetObject("btn_docente.Image")));
            this.btn_docente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_docente.Location = new System.Drawing.Point(-14, -30);
            this.btn_docente.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_docente.Name = "btn_docente";
            this.btn_docente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_docente.Size = new System.Drawing.Size(351, 107);
            this.btn_docente.TabIndex = 10;
            this.btn_docente.Text = "              Docente";
            this.btn_docente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_docente.UseVisualStyleBackColor = false;
            this.btn_docente.Click += new System.EventHandler(this.btn_docente_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-14, -20);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(351, 99);
            this.button8.TabIndex = 10;
            this.button8.Text = "          Gestionar Usuario";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.button12);
            this.panel14.Location = new System.Drawing.Point(0, 173);
            this.panel14.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(319, 64);
            this.panel14.TabIndex = 16;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btn_administrador);
            this.panel15.Location = new System.Drawing.Point(8, 8);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(319, 64);
            this.panel15.TabIndex = 12;
            // 
            // btn_administrador
            // 
            this.btn_administrador.BackColor = System.Drawing.Color.Blue;
            this.btn_administrador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrador.Image = ((System.Drawing.Image)(resources.GetObject("btn_administrador.Image")));
            this.btn_administrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_administrador.Location = new System.Drawing.Point(-14, -40);
            this.btn_administrador.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_administrador.Name = "btn_administrador";
            this.btn_administrador.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_administrador.Size = new System.Drawing.Size(351, 107);
            this.btn_administrador.TabIndex = 10;
            this.btn_administrador.Text = "              Administrador";
            this.btn_administrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_administrador.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Blue;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(-14, -21);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(351, 99);
            this.button12.TabIndex = 10;
            this.button12.Text = "          Gestionar Usuario";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Blue;
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.button10);
            this.panel12.Location = new System.Drawing.Point(0, 117);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(319, 64);
            this.panel12.TabIndex = 15;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_estudiante);
            this.panel13.Location = new System.Drawing.Point(8, 8);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(319, 64);
            this.panel13.TabIndex = 12;
            // 
            // btn_estudiante
            // 
            this.btn_estudiante.BackColor = System.Drawing.Color.Blue;
            this.btn_estudiante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estudiante.Image = ((System.Drawing.Image)(resources.GetObject("btn_estudiante.Image")));
            this.btn_estudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estudiante.Location = new System.Drawing.Point(-14, -30);
            this.btn_estudiante.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_estudiante.Name = "btn_estudiante";
            this.btn_estudiante.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_estudiante.Size = new System.Drawing.Size(351, 107);
            this.btn_estudiante.TabIndex = 10;
            this.btn_estudiante.Text = "              Estudiante";
            this.btn_estudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estudiante.UseVisualStyleBackColor = false;
            this.btn_estudiante.Click += new System.EventHandler(this.btn_estudiante_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Blue;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-14, -21);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(351, 99);
            this.button10.TabIndex = 10;
            this.button10.Text = "          Gestionar Usuario";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 64);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_usuarios);
            this.panel4.Location = new System.Drawing.Point(8, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 64);
            this.panel4.TabIndex = 12;
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.Navy;
            this.btn_usuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuarios.Image")));
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(-22, -29);
            this.btn_usuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_usuarios.Size = new System.Drawing.Size(359, 107);
            this.btn_usuarios.TabIndex = 10;
            this.btn_usuarios.Text = "                Gestionar Usuario";
            this.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-14, -21);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(351, 99);
            this.button1.TabIndex = 10;
            this.button1.Text = "          Gestionar Usuario";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.Navy;
            this.Barra.Controls.Add(this.panel_inicio);
            this.Barra.Controls.Add(this.panel_usuarios);
            this.Barra.Controls.Add(this.panel_materias);
            this.Barra.Controls.Add(this.panel_reportes);
            this.Barra.Controls.Add(this.panel_salir);
            this.Barra.Dock = System.Windows.Forms.DockStyle.Left;
            this.Barra.Location = new System.Drawing.Point(0, 119);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(479, 739);
            this.Barra.TabIndex = 17;
            // 
            // panel_inicio
            // 
            this.panel_inicio.Controls.Add(this.panel9);
            this.panel_inicio.Controls.Add(this.button13);
            this.panel_inicio.Location = new System.Drawing.Point(0, 3);
            this.panel_inicio.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel_inicio.Name = "panel_inicio";
            this.panel_inicio.Size = new System.Drawing.Size(319, 64);
            this.panel_inicio.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.bnt_inicio);
            this.panel9.Location = new System.Drawing.Point(8, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(319, 64);
            this.panel9.TabIndex = 12;
            // 
            // bnt_inicio
            // 
            this.bnt_inicio.BackColor = System.Drawing.Color.Navy;
            this.bnt_inicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_inicio.Image = ((System.Drawing.Image)(resources.GetObject("bnt_inicio.Image")));
            this.bnt_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_inicio.Location = new System.Drawing.Point(-22, -32);
            this.bnt_inicio.Name = "bnt_inicio";
            this.bnt_inicio.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.bnt_inicio.Size = new System.Drawing.Size(351, 109);
            this.bnt_inicio.TabIndex = 10;
            this.bnt_inicio.Text = "                INICIO";
            this.bnt_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_inicio.UseVisualStyleBackColor = false;
            this.bnt_inicio.Click += new System.EventHandler(this.bnt_inicio_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Navy;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(-14, -21);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(351, 99);
            this.button13.TabIndex = 10;
            this.button13.Text = "          Gestionar Usuario";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // panel_materias
            // 
            this.panel_materias.Controls.Add(this.panel5);
            this.panel_materias.Controls.Add(this.button3);
            this.panel_materias.Location = new System.Drawing.Point(0, 305);
            this.panel_materias.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel_materias.Name = "panel_materias";
            this.panel_materias.Size = new System.Drawing.Size(319, 64);
            this.panel_materias.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 64);
            this.panel5.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-22, -29);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(351, 107);
            this.button2.TabIndex = 10;
            this.button2.Text = "                Gestionar Materia";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-14, -21);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(351, 99);
            this.button3.TabIndex = 10;
            this.button3.Text = "          Gestionar Usuario";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel_reportes
            // 
            this.panel_reportes.Controls.Add(this.panel7);
            this.panel_reportes.Controls.Add(this.button5);
            this.panel_reportes.Location = new System.Drawing.Point(0, 375);
            this.panel_reportes.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel_reportes.Name = "panel_reportes";
            this.panel_reportes.Size = new System.Drawing.Size(319, 64);
            this.panel_reportes.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button4);
            this.panel7.Location = new System.Drawing.Point(8, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 64);
            this.panel7.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-22, -29);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(351, 107);
            this.button4.TabIndex = 10;
            this.button4.Text = "                Generar Reporte";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-14, -21);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(351, 99);
            this.button5.TabIndex = 10;
            this.button5.Text = "          Gestionar Usuario";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel_salir
            // 
            this.panel_salir.Controls.Add(this.panel17);
            this.panel_salir.Controls.Add(this.button15);
            this.panel_salir.Location = new System.Drawing.Point(0, 445);
            this.panel_salir.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel_salir.Name = "panel_salir";
            this.panel_salir.Size = new System.Drawing.Size(319, 64);
            this.panel_salir.TabIndex = 19;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button14);
            this.panel17.Location = new System.Drawing.Point(8, 8);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(319, 64);
            this.panel17.TabIndex = 12;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Navy;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(-22, -29);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(351, 107);
            this.button14.TabIndex = 10;
            this.button14.Text = "                Salir";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Navy;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(-14, -21);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button15.Size = new System.Drawing.Size(351, 99);
            this.button15.TabIndex = 10;
            this.button15.Text = "          Gestionar Usuario";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // FrmDevSchool
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1302, 858);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmDevSchool";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmDevSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_barra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_usuarios.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.Barra.ResumeLayout(false);
            this.panel_inicio.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel_materias.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_reportes.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel_salir.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_cerrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer TransicionMenu;
        private System.Windows.Forms.Timer BarraTransicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_barra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_usuarios;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btn_administrador;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_docente;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_estudiante;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel Barra;
        private System.Windows.Forms.Panel panel_materias;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel_reportes;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel_inicio;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button bnt_inicio;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel_salir;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
    }
}

