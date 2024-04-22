namespace ejercicio_cola
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstEsoera = new System.Windows.Forms.ListBox();
            this.lstSobreturno = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(151, 176);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 109);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(110, 271);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(110, 328);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(75, 23);
            this.btnLlamar.TabIndex = 7;
            this.btnLlamar.Text = "LLAMAR";
            this.btnLlamar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SOBRETURNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ESPERA";
            // 
            // lstEsoera
            // 
            this.lstEsoera.FormattingEnabled = true;
            this.lstEsoera.Location = new System.Drawing.Point(330, 54);
            this.lstEsoera.Name = "lstEsoera";
            this.lstEsoera.Size = new System.Drawing.Size(190, 134);
            this.lstEsoera.TabIndex = 10;
            // 
            // lstSobreturno
            // 
            this.lstSobreturno.FormattingEnabled = true;
            this.lstSobreturno.Location = new System.Drawing.Point(330, 252);
            this.lstSobreturno.Name = "lstSobreturno";
            this.lstSobreturno.Size = new System.Drawing.Size(190, 147);
            this.lstSobreturno.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.lstSobreturno);
            this.Controls.Add(this.lstEsoera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstEsoera;
        private System.Windows.Forms.ListBox lstSobreturno;
    }
}

