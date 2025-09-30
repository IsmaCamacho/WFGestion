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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDatos = new System.Windows.Forms.TabPage();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.tpVisualizacion = new System.Windows.Forms.TabPage();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(417, 53);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1447, 573);
            this.tabControl1.TabIndex = 1;
            // 
            // tbDatos
            // 
            this.tbDatos.Location = new System.Drawing.Point(4, 25);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbDatos.Size = new System.Drawing.Size(1439, 544);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.Text = "Datos Personales";
            this.tbDatos.UseVisualStyleBackColor = true;
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Location = new System.Drawing.Point(4, 25);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferencias.Size = new System.Drawing.Size(1439, 544);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // tpVisualizacion
            // 
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
            this.btGuardar.Location = new System.Drawing.Point(229, 679);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(191, 70);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(1024, 679);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(191, 70);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(612, 679);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(191, 70);
            this.btLimpiar.TabIndex = 4;
            this.btLimpiar.Text = "LIMPIAR";
            this.btLimpiar.UseVisualStyleBackColor = true;
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
    }
}

