namespace Iglesia
{
    partial class AgregarIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarIngresos));
            this.comboBox1TipoIngreso = new System.Windows.Forms.ComboBox();
            this.button3Limpiar = new System.Windows.Forms.Button();
            this.button1Guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtMONTO = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1TipoIngreso
            // 
            this.comboBox1TipoIngreso.FormattingEnabled = true;
            this.comboBox1TipoIngreso.Location = new System.Drawing.Point(196, 89);
            this.comboBox1TipoIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1TipoIngreso.Name = "comboBox1TipoIngreso";
            this.comboBox1TipoIngreso.Size = new System.Drawing.Size(181, 24);
            this.comboBox1TipoIngreso.TabIndex = 35;
            this.comboBox1TipoIngreso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3Limpiar
            // 
            this.button3Limpiar.Font = new System.Drawing.Font("Calibri Light", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Limpiar.Location = new System.Drawing.Point(407, 198);
            this.button3Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.button3Limpiar.Name = "button3Limpiar";
            this.button3Limpiar.Size = new System.Drawing.Size(104, 39);
            this.button3Limpiar.TabIndex = 47;
            this.button3Limpiar.Text = "Limpiar";
            this.button3Limpiar.UseVisualStyleBackColor = true;
            this.button3Limpiar.Click += new System.EventHandler(this.button3Limpiar_Click);
            // 
            // button1Guardar
            // 
            this.button1Guardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1Guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Guardar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Guardar.Location = new System.Drawing.Point(407, 109);
            this.button1Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.button1Guardar.Name = "button1Guardar";
            this.button1Guardar.Size = new System.Drawing.Size(104, 47);
            this.button1Guardar.TabIndex = 46;
            this.button1Guardar.Text = "Guardar";
            this.button1Guardar.UseVisualStyleBackColor = false;
            this.button1Guardar.Click += new System.EventHandler(this.button1Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(221, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo de Ingreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(246, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(246, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDetalle.Location = new System.Drawing.Point(196, 150);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(181, 23);
            this.txtDetalle.TabIndex = 2;
            // 
            // txtMONTO
            // 
            this.txtMONTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMONTO.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMONTO.Location = new System.Drawing.Point(211, 237);
            this.txtMONTO.Margin = new System.Windows.Forms.Padding(4);
            this.txtMONTO.Name = "txtMONTO";
            this.txtMONTO.Size = new System.Drawing.Size(132, 23);
            this.txtMONTO.TabIndex = 3;
            this.txtMONTO.TextChanged += new System.EventHandler(this.txtMONTO_TextChanged);
            this.txtMONTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMONTO_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::arreglarTesis.Properties.Resources._81;
            this.pictureBox2.Location = new System.Drawing.Point(322, 162);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 212);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cargar datos del Ingreso:";
            // 
            // AgregarIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(655, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1TipoIngreso);
            this.Controls.Add(this.button3Limpiar);
            this.Controls.Add(this.button1Guardar);
            this.Controls.Add(this.txtMONTO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(673, 423);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(673, 423);
            this.Name = "AgregarIngresos";
            this.Text = "AgregarIngresos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtMONTO;
        private System.Windows.Forms.Button button3Limpiar;
        private System.Windows.Forms.Button button1Guardar;
        private System.Windows.Forms.ComboBox comboBox1TipoIngreso;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}