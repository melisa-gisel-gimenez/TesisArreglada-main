namespace arreglarTesis
{
    partial class AsignarMiembrosCelula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarMiembrosCelula));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.txtDNIBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCelula = new System.Windows.Forms.ComboBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonListaCelula = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdCelula = new System.Windows.Forms.TextBox();
            this.txtIdMiembro = new System.Windows.Forms.TextBox();
            this.checkBoxInhabilitado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Miembros de Celula";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(330, 94);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(63, 46);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // txtDNIBuscar
            // 
            this.txtDNIBuscar.Location = new System.Drawing.Point(160, 107);
            this.txtDNIBuscar.Name = "txtDNIBuscar";
            this.txtDNIBuscar.Size = new System.Drawing.Size(153, 22);
            this.txtDNIBuscar.TabIndex = 2;
            this.txtDNIBuscar.TextChanged += new System.EventHandler(this.textBoxDNIBuscar_TextChanged_1);
            this.txtDNIBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIBuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(159, 165);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(160, 205);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 22);
            this.txtApellido.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Asignar a Celula Nro:";
            // 
            // comboBoxCelula
            // 
            this.comboBoxCelula.Enabled = false;
            this.comboBoxCelula.FormattingEnabled = true;
            this.comboBoxCelula.Location = new System.Drawing.Point(189, 242);
            this.comboBoxCelula.Name = "comboBoxCelula";
            this.comboBoxCelula.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCelula.TabIndex = 9;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.Location = new System.Drawing.Point(64, 296);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(93, 65);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click_1);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
            this.buttonLimpiar.Location = new System.Drawing.Point(335, 217);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(58, 48);
            this.buttonLimpiar.TabIndex = 11;
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonListaCelula
            // 
            this.buttonListaCelula.Location = new System.Drawing.Point(179, 296);
            this.buttonListaCelula.Name = "buttonListaCelula";
            this.buttonListaCelula.Size = new System.Drawing.Size(151, 65);
            this.buttonListaCelula.TabIndex = 12;
            this.buttonListaCelula.Text = "Ver Lista de Miembros por Celula";
            this.buttonListaCelula.UseVisualStyleBackColor = true;
            this.buttonListaCelula.Click += new System.EventHandler(this.buttonListaCelula_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arreglarTesis.Properties.Resources.Diseño_sin_título__16_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 416);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdCelula
            // 
            this.txtIdCelula.Enabled = false;
            this.txtIdCelula.Location = new System.Drawing.Point(386, 367);
            this.txtIdCelula.Name = "txtIdCelula";
            this.txtIdCelula.Size = new System.Drawing.Size(63, 22);
            this.txtIdCelula.TabIndex = 17;
            this.txtIdCelula.Visible = false;
            // 
            // txtIdMiembro
            // 
            this.txtIdMiembro.Enabled = false;
            this.txtIdMiembro.Location = new System.Drawing.Point(386, 339);
            this.txtIdMiembro.Name = "txtIdMiembro";
            this.txtIdMiembro.Size = new System.Drawing.Size(63, 22);
            this.txtIdMiembro.TabIndex = 16;
            this.txtIdMiembro.Visible = false;
            // 
            // checkBoxInhabilitado
            // 
            this.checkBoxInhabilitado.AutoSize = true;
            this.checkBoxInhabilitado.Enabled = false;
            this.checkBoxInhabilitado.Location = new System.Drawing.Point(330, 181);
            this.checkBoxInhabilitado.Name = "checkBoxInhabilitado";
            this.checkBoxInhabilitado.Size = new System.Drawing.Size(98, 20);
            this.checkBoxInhabilitado.TabIndex = 18;
            this.checkBoxInhabilitado.Text = "Inhabilitado";
            this.checkBoxInhabilitado.UseVisualStyleBackColor = true;
            // 
            // AsignarMiembrosCelula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 402);
            this.Controls.Add(this.checkBoxInhabilitado);
            this.Controls.Add(this.txtIdCelula);
            this.Controls.Add(this.txtIdMiembro);
            this.Controls.Add(this.buttonListaCelula);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxCelula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNIBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(469, 449);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(469, 449);
            this.Name = "AsignarMiembrosCelula";
            this.Text = "AsignarMiembrosCelula";
            this.Load += new System.EventHandler(this.AsignarMiembrosCelula_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox txtDNIBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCelula;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonListaCelula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIdCelula;
        private System.Windows.Forms.TextBox txtIdMiembro;
        private System.Windows.Forms.CheckBox checkBoxInhabilitado;
    }
}