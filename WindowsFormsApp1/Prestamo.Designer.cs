namespace WindowsFormsApp1
{
    partial class prestamo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prestamo));
            this.saludo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datosPrestamos = new System.Windows.Forms.Panel();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datosPersonales = new System.Windows.Forms.Panel();
            this.lugares = new System.Windows.Forms.ComboBox();
            this.razas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.datosPrestamos.SuspendLayout();
            this.datosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Location = new System.Drawing.Point(67, 35);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(63, 13);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Bienvenido,";
            this.saludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(697, 385);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 53);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(331, 332);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(148, 59);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar Solicitud";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datos personales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datos prestamo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // datosPrestamos
            // 
            this.datosPrestamos.BackColor = System.Drawing.Color.White;
            this.datosPrestamos.Controls.Add(this.txtMonto);
            this.datosPrestamos.Controls.Add(this.cuotas);
            this.datosPrestamos.Controls.Add(this.label7);
            this.datosPrestamos.Controls.Add(this.label6);
            this.datosPrestamos.Location = new System.Drawing.Point(466, 136);
            this.datosPrestamos.Name = "datosPrestamos";
            this.datosPrestamos.Size = new System.Drawing.Size(286, 128);
            this.datosPrestamos.TabIndex = 6;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(130, 19);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(139, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // cuotas
            // 
            this.cuotas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(83, 82);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(186, 21);
            this.cuotas.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cuotas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monto del prestamo";
            // 
            // datosPersonales
            // 
            this.datosPersonales.BackColor = System.Drawing.Color.White;
            this.datosPersonales.Controls.Add(this.lugares);
            this.datosPersonales.Controls.Add(this.razas);
            this.datosPersonales.Controls.Add(this.label5);
            this.datosPersonales.Controls.Add(this.label4);
            this.datosPersonales.Location = new System.Drawing.Point(70, 136);
            this.datosPersonales.Name = "datosPersonales";
            this.datosPersonales.Size = new System.Drawing.Size(286, 128);
            this.datosPersonales.TabIndex = 7;
            // 
            // lugares
            // 
            this.lugares.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lugares.FormattingEnabled = true;
            this.lugares.Location = new System.Drawing.Point(112, 79);
            this.lugares.Name = "lugares";
            this.lugares.Size = new System.Drawing.Size(148, 21);
            this.lugares.TabIndex = 3;
            // 
            // razas
            // 
            this.razas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.razas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.razas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.razas.FormattingEnabled = true;
            this.razas.Location = new System.Drawing.Point(74, 19);
            this.razas.Name = "razas";
            this.razas.Size = new System.Drawing.Size(186, 21);
            this.razas.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lugar de origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Raza";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.datosPersonales);
            this.Controls.Add(this.datosPrestamos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.saludo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "prestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.datosPrestamos.ResumeLayout(false);
            this.datosPrestamos.PerformLayout();
            this.datosPersonales.ResumeLayout(false);
            this.datosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel datosPrestamos;
        private System.Windows.Forms.Panel datosPersonales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.ComboBox lugares;
        private System.Windows.Forms.ComboBox razas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}