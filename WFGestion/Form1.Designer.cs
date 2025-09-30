namespace WFGestion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDatos = new System.Windows.Forms.TabPage();
            this.lbEdad = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbSexo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbOtro = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.lbCalificacion = new System.Windows.Forms.Label();
            this.tbCalificar = new System.Windows.Forms.TrackBar();
            this.lbPais = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbHobbies = new System.Windows.Forms.CheckedListBox();
            this.cbBoletin = new System.Windows.Forms.CheckBox();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalificar)).BeginInit();
            this.tpVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(417, 54);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(541, 29);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Gestión Avanzada de Información Personal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDatos);
            this.tabControl1.Controls.Add(this.tpPreferencias);
            this.tabControl1.Controls.Add(this.tpVisualizacion);
            this.tabControl1.Location = new System.Drawing.Point(12, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1447, 573);
            this.tabControl1.TabIndex = 1;
            // 
            // tbDatos
            // 
            this.tbDatos.Controls.Add(this.lbEdad);
            this.tbDatos.Controls.Add(this.nudEdad);
            this.tbDatos.Controls.Add(this.lbFechaNac);
            this.tbDatos.Controls.Add(this.monthCalendar1);
            this.tbDatos.Controls.Add(this.lbSexo);
            this.tbDatos.Controls.Add(this.panel1);
            this.tbDatos.Controls.Add(this.tbNombre);
            this.tbDatos.Controls.Add(this.tbDireccion);
            this.tbDatos.Controls.Add(this.tbCorreo);
            this.tbDatos.Controls.Add(this.lbCorreo);
            this.tbDatos.Controls.Add(this.lbDireccion);
            this.tbDatos.Controls.Add(this.lbNombre);
            this.tbDatos.Location = new System.Drawing.Point(4, 25);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbDatos.Size = new System.Drawing.Size(1439, 544);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.Text = "Datos Personales";
            this.tbDatos.UseVisualStyleBackColor = true;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(1003, 369);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(199, 25);
            this.lbEdad.TabIndex = 11;
            this.lbEdad.Text = "Fecha de nacimiento:";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(987, 426);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(230, 22);
            this.nudEdad.TabIndex = 10;
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNac.Location = new System.Drawing.Point(588, 240);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(199, 25);
            this.lbFechaNac.TabIndex = 9;
            this.lbFechaNac.Text = "Fecha de nacimiento:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(579, 286);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(139, 221);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(58, 25);
            this.lbSexo.TabIndex = 7;
            this.lbSexo.Text = "Sexo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbOtro);
            this.panel1.Controls.Add(this.rbFemenino);
            this.panel1.Controls.Add(this.rbMasculino);
            this.panel1.Location = new System.Drawing.Point(40, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 216);
            this.panel1.TabIndex = 6;
            // 
            // tbOtro
            // 
            this.tbOtro.AutoSize = true;
            this.tbOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOtro.Location = new System.Drawing.Point(26, 166);
            this.tbOtro.Name = "tbOtro";
            this.tbOtro.Size = new System.Drawing.Size(63, 24);
            this.tbOtro.TabIndex = 2;
            this.tbOtro.TabStop = true;
            this.tbOtro.Text = "Otro";
            this.tbOtro.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(26, 94);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(103, 24);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(26, 26);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(106, 24);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(23, 161);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(177, 22);
            this.tbNombre.TabIndex = 5;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(441, 161);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(275, 22);
            this.tbDireccion.TabIndex = 4;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(960, 161);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(257, 22);
            this.tbCorreo.TabIndex = 3;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(1003, 105);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(171, 25);
            this.lbCorreo.TabIndex = 2;
            this.lbCorreo.Text = "Correo electrónico";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(513, 105);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(93, 25);
            this.lbDireccion.TabIndex = 1;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(69, 105);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(81, 25);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Controls.Add(this.lbCalificacion);
            this.tpPreferencias.Controls.Add(this.tbCalificar);
            this.tpPreferencias.Controls.Add(this.lbPais);
            this.tpPreferencias.Controls.Add(this.cbPais);
            this.tpPreferencias.Controls.Add(this.label1);
            this.tpPreferencias.Controls.Add(this.clbHobbies);
            this.tpPreferencias.Controls.Add(this.cbBoletin);
            this.tpPreferencias.Location = new System.Drawing.Point(4, 25);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferencias.Size = new System.Drawing.Size(1439, 544);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // lbCalificacion
            // 
            this.lbCalificacion.AutoSize = true;
            this.lbCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalificacion.Location = new System.Drawing.Point(965, 290);
            this.lbCalificacion.Name = "lbCalificacion";
            this.lbCalificacion.Size = new System.Drawing.Size(382, 25);
            this.lbCalificacion.TabIndex = 6;
            this.lbCalificacion.Text = "Califica tú satisfacción con nuestro servicio";
            // 
            // tbCalificar
            // 
            this.tbCalificar.Location = new System.Drawing.Point(953, 340);
            this.tbCalificar.Name = "tbCalificar";
            this.tbCalificar.Size = new System.Drawing.Size(405, 56);
            this.tbCalificar.TabIndex = 5;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPais.Location = new System.Drawing.Point(607, 290);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(237, 25);
            this.lbPais.TabIndex = 4;
            this.lbPais.Text = "Elige el país de residencia";
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Francia",
            "Portugal",
            "Inglaterra",
            "Italia",
            "Paises Bajos",
            "Letunia",
            "Letonia",
            "Noruega",
            "Alemania",
            "Suiza",
            "Grecia",
            "Rusia"});
            this.cbPais.Location = new System.Drawing.Point(540, 349);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(331, 24);
            this.cbPais.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona tus hobbies";
            // 
            // clbHobbies
            // 
            this.clbHobbies.FormattingEnabled = true;
            this.clbHobbies.Items.AddRange(new object[] {
            "Viajar",
            "Ver la tele",
            "Jugar a futbol",
            "Leer",
            "Caminar",
            "Correr",
            "Gimnasio",
            "Programar",
            "Estudiar inglés",
            "Tocar la guitarra"});
            this.clbHobbies.Location = new System.Drawing.Point(34, 126);
            this.clbHobbies.Name = "clbHobbies";
            this.clbHobbies.Size = new System.Drawing.Size(369, 395);
            this.clbHobbies.TabIndex = 1;
            // 
            // cbBoletin
            // 
            this.cbBoletin.AutoSize = true;
            this.cbBoletin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoletin.Location = new System.Drawing.Point(451, 25);
            this.cbBoletin.Name = "cbBoletin";
            this.cbBoletin.Size = new System.Drawing.Size(298, 33);
            this.cbBoletin.TabIndex = 0;
            this.cbBoletin.Text = "¿Suscribirse al boletín?";
            this.cbBoletin.UseVisualStyleBackColor = true;
            // 
            // tpVisualizacion
            // 
            this.tpVisualizacion.Controls.Add(this.lbHora);
            this.tpVisualizacion.Controls.Add(this.pictureBox1);
            this.tpVisualizacion.Location = new System.Drawing.Point(4, 25);
            this.tpVisualizacion.Name = "tpVisualizacion";
            this.tpVisualizacion.Size = new System.Drawing.Size(1439, 544);
            this.tpVisualizacion.TabIndex = 2;
            this.tpVisualizacion.Text = "Visualizacion";
            this.tpVisualizacion.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(229, 680);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(191, 70);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(1024, 680);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(191, 70);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(612, 680);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(191, 70);
            this.btLimpiar.TabIndex = 4;
            this.btLimpiar.Text = "LIMPIAR";
            this.btLimpiar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(934, 148);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(0, 20);
            this.lbHora.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 777);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Gestión Avanzada de Información Personal.";
            this.tabControl1.ResumeLayout(false);
            this.tbDatos.ResumeLayout(false);
            this.tbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpPreferencias.ResumeLayout(false);
            this.tpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalificar)).EndInit();
            this.tpVisualizacion.ResumeLayout(false);
            this.tpVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDatos;
        private System.Windows.Forms.TabPage tpPreferencias;
        private System.Windows.Forms.TabPage tpVisualizacion;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton tbOtro;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.CheckBox cbBoletin;
        private System.Windows.Forms.CheckedListBox clbHobbies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lbCalificacion;
        private System.Windows.Forms.TrackBar tbCalificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

