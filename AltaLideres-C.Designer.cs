namespace arreglarTesis
{
    partial class AltaCelula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCelula));
            this.label1 = new System.Windows.Forms.Label();
            this.DGVCelulas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNIBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAgregarCelula = new System.Windows.Forms.Button();
            this.btnAltaLider = new System.Windows.Forms.Button();
            this.txtIdCelula = new System.Windows.Forms.TextBox();
            this.txtIdMiembro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEtapa = new System.Windows.Forms.TextBox();
            this.txtRol2 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCelulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celulas existentes";
            // 
            // DGVCelulas
            // 
            this.DGVCelulas.AllowUserToAddRows = false;
            this.DGVCelulas.AllowUserToDeleteRows = false;
            this.DGVCelulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCelulas.Location = new System.Drawing.Point(49, 65);
            this.DGVCelulas.Name = "DGVCelulas";
            this.DGVCelulas.ReadOnly = true;
            this.DGVCelulas.RowHeadersWidth = 51;
            this.DGVCelulas.RowTemplate.Height = 24;
            this.DGVCelulas.Size = new System.Drawing.Size(300, 241);
            this.DGVCelulas.TabIndex = 1;
            this.DGVCelulas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCelulas_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(369, 322);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 47);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI Lider Nueva Celula:";
            // 
            // txtDNIBuscar
            // 
            this.txtDNIBuscar.Location = new System.Drawing.Point(225, 349);
            this.txtDNIBuscar.Name = "txtDNIBuscar";
            this.txtDNIBuscar.Size = new System.Drawing.Size(125, 22);
            this.txtDNIBuscar.TabIndex = 4;
            this.txtDNIBuscar.TextChanged += new System.EventHandler(this.txtDNIBuscar_TextChanged_1);
            this.txtDNIBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIBuscar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(225, 393);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(225, 434);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 22);
            this.txtApellido.TabIndex = 8;
            // 
            // btnAgregarCelula
            // 
            this.btnAgregarCelula.Location = new System.Drawing.Point(412, 78);
            this.btnAgregarCelula.Name = "btnAgregarCelula";
            this.btnAgregarCelula.Size = new System.Drawing.Size(100, 40);
            this.btnAgregarCelula.TabIndex = 9;
            this.btnAgregarCelula.Text = "Crear Celula";
            this.btnAgregarCelula.UseVisualStyleBackColor = true;
            this.btnAgregarCelula.Click += new System.EventHandler(this.btnAgregarCelula_Click);
            // 
            // btnAltaLider
            // 
            this.btnAltaLider.Enabled = false;
            this.btnAltaLider.Location = new System.Drawing.Point(49, 480);
            this.btnAltaLider.Name = "btnAltaLider";
            this.btnAltaLider.Size = new System.Drawing.Size(164, 43);
            this.btnAltaLider.TabIndex = 10;
            this.btnAltaLider.Text = "Asignar Lider";
            this.btnAltaLider.UseVisualStyleBackColor = true;
            this.btnAltaLider.Click += new System.EventHandler(this.btnAltaLider_Click);
            // 
            // txtIdCelula
            // 
            this.txtIdCelula.Enabled = false;
            this.txtIdCelula.Location = new System.Drawing.Point(412, 137);
            this.txtIdCelula.Name = "txtIdCelula";
            this.txtIdCelula.Size = new System.Drawing.Size(100, 22);
            this.txtIdCelula.TabIndex = 11;
            this.txtIdCelula.Visible = false;
            // 
            // txtIdMiembro
            // 
            this.txtIdMiembro.Enabled = false;
            this.txtIdMiembro.Location = new System.Drawing.Point(412, 164);
            this.txtIdMiembro.Name = "txtIdMiembro";
            this.txtIdMiembro.Size = new System.Drawing.Size(100, 22);
            this.txtIdMiembro.TabIndex = 12;
            this.txtIdMiembro.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ver Lista Miembros por celula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEtapa
            // 
            this.txtEtapa.Enabled = false;
            this.txtEtapa.Location = new System.Drawing.Point(412, 222);
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.Size = new System.Drawing.Size(100, 22);
            this.txtEtapa.TabIndex = 14;
            this.txtEtapa.Visible = false;
            // 
            // txtRol2
            // 
            this.txtRol2.Enabled = false;
            this.txtRol2.Location = new System.Drawing.Point(412, 249);
            this.txtRol2.Name = "txtRol2";
            this.txtRol2.Size = new System.Drawing.Size(100, 22);
            this.txtRol2.TabIndex = 15;
            this.txtRol2.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(369, 408);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 46);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 620);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AltaCelula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 609);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtRol2);
            this.Controls.Add(this.txtEtapa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdMiembro);
            this.Controls.Add(this.txtIdCelula);
            this.Controls.Add(this.btnAltaLider);
            this.Controls.Add(this.btnAgregarCelula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDNIBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.DGVCelulas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaCelula";
            this.Text = "AltaCelula";
            this.Load += new System.EventHandler(this.AltaCelula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCelulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVCelulas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNIBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAgregarCelula;
        private System.Windows.Forms.Button btnAltaLider;
        private System.Windows.Forms.TextBox txtIdCelula;
        private System.Windows.Forms.TextBox txtIdMiembro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEtapa;
        private System.Windows.Forms.TextBox txtRol2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}