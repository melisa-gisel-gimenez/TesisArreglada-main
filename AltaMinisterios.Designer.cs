namespace Iglesia
{
    partial class AltaMinisterios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMinisterios));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreMini = new System.Windows.Forms.TextBox();
            this.DGVMini = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCrearMinisterio = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNIBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtIdMiembro = new System.Windows.Forms.TextBox();
            this.btnAsignarLider = new System.Windows.Forms.Button();
            this.txtIdMinisterio = new System.Windows.Forms.TextBox();
            this.txtEtapa = new System.Windows.Forms.TextBox();
            this.txtRoli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Ministerio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNombreMini
            // 
            this.textBoxNombreMini.Location = new System.Drawing.Point(217, 297);
            this.textBoxNombreMini.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxNombreMini.Name = "textBoxNombreMini";
            this.textBoxNombreMini.Size = new System.Drawing.Size(256, 26);
            this.textBoxNombreMini.TabIndex = 2;
            this.textBoxNombreMini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreMini_KeyPress_1);
            // 
            // DGVMini
            // 
            this.DGVMini.AllowUserToAddRows = false;
            this.DGVMini.AllowUserToDeleteRows = false;
            this.DGVMini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVMini.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVMini.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGVMini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMini.EnableHeadersVisualStyles = false;
            this.DGVMini.Location = new System.Drawing.Point(27, 80);
            this.DGVMini.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DGVMini.Name = "DGVMini";
            this.DGVMini.ReadOnly = true;
            this.DGVMini.RowHeadersWidth = 51;
            this.DGVMini.RowTemplate.Height = 24;
            this.DGVMini.Size = new System.Drawing.Size(713, 188);
            this.DGVMini.TabIndex = 3;
            this.DGVMini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMini_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ministerios Existentes:";
            // 
            // buttonCrearMinisterio
            // 
            this.buttonCrearMinisterio.Enabled = false;
            this.buttonCrearMinisterio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.buttonCrearMinisterio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCrearMinisterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearMinisterio.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearMinisterio.Location = new System.Drawing.Point(610, 278);
            this.buttonCrearMinisterio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonCrearMinisterio.Name = "buttonCrearMinisterio";
            this.buttonCrearMinisterio.Size = new System.Drawing.Size(130, 60);
            this.buttonCrearMinisterio.TabIndex = 5;
            this.buttonCrearMinisterio.Text = "Crear Ministerio";
            this.buttonCrearMinisterio.UseVisualStyleBackColor = true;
            this.buttonCrearMinisterio.Click += new System.EventHandler(this.buttonCrearMinisterio_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(610, 443);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(130, 65);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::arreglarTesis.Properties.Resources._3_1_;
            this.pictureBox3.Location = new System.Drawing.Point(0, -1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(767, 578);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese DNI Lider:";
            // 
            // txtDNIBuscar
            // 
            this.txtDNIBuscar.Location = new System.Drawing.Point(217, 376);
            this.txtDNIBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDNIBuscar.Name = "txtDNIBuscar";
            this.txtDNIBuscar.Size = new System.Drawing.Size(178, 26);
            this.txtDNIBuscar.TabIndex = 12;
            this.txtDNIBuscar.TextChanged += new System.EventHandler(this.txtDNIBuscar_TextChanged);
            this.txtDNIBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(408, 353);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 49);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(217, 420);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 26);
            this.txtNombre.TabIndex = 16;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(217, 473);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(178, 26);
            this.txtApellido.TabIndex = 17;
            // 
            // txtIdMiembro
            // 
            this.txtIdMiembro.Enabled = false;
            this.txtIdMiembro.Location = new System.Drawing.Point(408, 407);
            this.txtIdMiembro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdMiembro.Name = "txtIdMiembro";
            this.txtIdMiembro.Size = new System.Drawing.Size(72, 26);
            this.txtIdMiembro.TabIndex = 18;
            this.txtIdMiembro.Visible = false;
            // 
            // btnAsignarLider
            // 
            this.btnAsignarLider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnAsignarLider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAsignarLider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarLider.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarLider.Location = new System.Drawing.Point(610, 363);
            this.btnAsignarLider.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAsignarLider.Name = "btnAsignarLider";
            this.btnAsignarLider.Size = new System.Drawing.Size(130, 70);
            this.btnAsignarLider.TabIndex = 19;
            this.btnAsignarLider.Text = "Asignar Lider";
            this.btnAsignarLider.UseVisualStyleBackColor = true;
            this.btnAsignarLider.Click += new System.EventHandler(this.btnAsignarLider_Click);
            // 
            // txtIdMinisterio
            // 
            this.txtIdMinisterio.Enabled = false;
            this.txtIdMinisterio.Location = new System.Drawing.Point(501, 295);
            this.txtIdMinisterio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdMinisterio.Name = "txtIdMinisterio";
            this.txtIdMinisterio.Size = new System.Drawing.Size(72, 26);
            this.txtIdMinisterio.TabIndex = 20;
            this.txtIdMinisterio.Visible = false;
            // 
            // txtEtapa
            // 
            this.txtEtapa.Enabled = false;
            this.txtEtapa.Location = new System.Drawing.Point(408, 441);
            this.txtEtapa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.Size = new System.Drawing.Size(72, 26);
            this.txtEtapa.TabIndex = 21;
            this.txtEtapa.Visible = false;
            // 
            // txtRoli
            // 
            this.txtRoli.Enabled = false;
            this.txtRoli.Location = new System.Drawing.Point(408, 477);
            this.txtRoli.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRoli.Name = "txtRoli";
            this.txtRoli.Size = new System.Drawing.Size(72, 26);
            this.txtRoli.TabIndex = 22;
            this.txtRoli.Visible = false;
            // 
            // AltaMinisterios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.txtRoli);
            this.Controls.Add(this.txtEtapa);
            this.Controls.Add(this.txtIdMinisterio);
            this.Controls.Add(this.btnAsignarLider);
            this.Controls.Add(this.txtIdMiembro);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDNIBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrearMinisterio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVMini);
            this.Controls.Add(this.textBoxNombreMini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaMinisterios";
            this.Text = "Ministerios";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreMini;
        private System.Windows.Forms.DataGridView DGVMini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCrearMinisterio;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNIBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtIdMiembro;
        private System.Windows.Forms.Button btnAsignarLider;
        private System.Windows.Forms.TextBox txtIdMinisterio;
        private System.Windows.Forms.TextBox txtEtapa;
        private System.Windows.Forms.TextBox txtRoli;
    }
}