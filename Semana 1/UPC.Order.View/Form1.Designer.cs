namespace UPC.Order.View
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.comboBoxDescripcion = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labelTotalNeto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(961, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.15385F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE VENTA DE PRODUCTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPC.Order.View.Properties.Resources.logo_0_25x;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DEL CLIENTE O RAZON SOCIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIPCIÓN DEL PRODUCTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "CANTIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "PRECIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(668, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "FECHA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(804, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "HORA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(618, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "TOTAL NETO A PAGAR";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(668, 137);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(54, 22);
            this.labelFecha.TabIndex = 8;
            this.labelFecha.Text = "fecha";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(804, 137);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(46, 22);
            this.labelHora.TabIndex = 9;
            this.labelHora.Text = "hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F);
            this.textBoxNombreCliente.Location = new System.Drawing.Point(16, 134);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(585, 28);
            this.textBoxNombreCliente.TabIndex = 10;
            // 
            // comboBoxDescripcion
            // 
            this.comboBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F);
            this.comboBoxDescripcion.FormattingEnabled = true;
            this.comboBoxDescripcion.Location = new System.Drawing.Point(16, 208);
            this.comboBoxDescripcion.Name = "comboBoxDescripcion";
            this.comboBoxDescripcion.Size = new System.Drawing.Size(278, 30);
            this.comboBoxDescripcion.TabIndex = 11;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F);
            this.textBoxCantidad.Location = new System.Drawing.Point(320, 208);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(186, 28);
            this.textBoxCantidad.TabIndex = 12;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F);
            this.labelPrecio.Location = new System.Drawing.Point(523, 211);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(45, 22);
            this.labelPrecio.TabIndex = 13;
            this.labelPrecio.Text = "0.00";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegistrar.Location = new System.Drawing.Point(672, 183);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(265, 62);
            this.buttonRegistrar.TabIndex = 14;
            this.buttonRegistrar.Text = "REGISTRAR";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(16, 264);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(921, 178);
            this.listView.TabIndex = 15;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(16, 465);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 38);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelTotalNeto
            // 
            this.labelTotalNeto.AutoSize = true;
            this.labelTotalNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalNeto.Location = new System.Drawing.Point(875, 467);
            this.labelTotalNeto.Name = "labelTotalNeto";
            this.labelTotalNeto.Size = new System.Drawing.Size(62, 29);
            this.labelTotalNeto.TabIndex = 17;
            this.labelTotalNeto.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(960, 519);
            this.Controls.Add(this.labelTotalNeto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.comboBoxDescripcion);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.ComboBox comboBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labelTotalNeto;
    }
}

