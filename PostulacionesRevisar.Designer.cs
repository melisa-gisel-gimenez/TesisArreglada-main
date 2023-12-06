namespace Iglesia
{
    partial class PostulacionesRevisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostulacionesRevisar));
            this.label1 = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.labelIDPostulacion = new System.Windows.Forms.Label();
            this.buttonAprobar = new System.Windows.Forms.Button();
            this.labelIDMiembro = new System.Windows.Forms.Label();
            this.labelIDProxEtapa = new System.Windows.Forms.Label();
            this.labelFechaAlta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.textBoxProxEtapa = new System.Windows.Forms.TextBox();
            this.textBoxFechaAltaEtapa = new System.Windows.Forms.TextBox();
            this.textBoxEtapaActual = new System.Windows.Forms.TextBox();
            this.textBoxApellidoM = new System.Windows.Forms.TextBox();
            this.textBoxNombreM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidatos a Evaluar para  aprobar evolucion espiritual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(46, 137);
            this.DGV1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(1144, 265);
            this.DGV1.TabIndex = 1;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // labelIDPostulacion
            // 
            this.labelIDPostulacion.AutoSize = true;
            this.labelIDPostulacion.Location = new System.Drawing.Point(40, 369);
            this.labelIDPostulacion.Name = "labelIDPostulacion";
            this.labelIDPostulacion.Size = new System.Drawing.Size(0, 23);
            this.labelIDPostulacion.TabIndex = 2;
            this.labelIDPostulacion.UseCompatibleTextRendering = true;
            this.labelIDPostulacion.Visible = false;
            // 
            // buttonAprobar
            // 
            this.buttonAprobar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.buttonAprobar.Location = new System.Drawing.Point(384, 697);
            this.buttonAprobar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAprobar.Name = "buttonAprobar";
            this.buttonAprobar.Size = new System.Drawing.Size(123, 69);
            this.buttonAprobar.TabIndex = 3;
            this.buttonAprobar.Text = "APROBAR";
            this.buttonAprobar.UseVisualStyleBackColor = true;
            this.buttonAprobar.Click += new System.EventHandler(this.buttonAprobar_Click);
            // 
            // labelIDMiembro
            // 
            this.labelIDMiembro.AutoSize = true;
            this.labelIDMiembro.Location = new System.Drawing.Point(426, 350);
            this.labelIDMiembro.Name = "labelIDMiembro";
            this.labelIDMiembro.Size = new System.Drawing.Size(0, 23);
            this.labelIDMiembro.TabIndex = 4;
            this.labelIDMiembro.UseCompatibleTextRendering = true;
            this.labelIDMiembro.Visible = false;
            // 
            // labelIDProxEtapa
            // 
            this.labelIDProxEtapa.AutoSize = true;
            this.labelIDProxEtapa.Location = new System.Drawing.Point(507, 583);
            this.labelIDProxEtapa.Name = "labelIDProxEtapa";
            this.labelIDProxEtapa.Size = new System.Drawing.Size(0, 23);
            this.labelIDProxEtapa.TabIndex = 5;
            this.labelIDProxEtapa.UseCompatibleTextRendering = true;
            this.labelIDProxEtapa.Visible = false;
            // 
            // labelFechaAlta
            // 
            this.labelFechaAlta.AutoSize = true;
            this.labelFechaAlta.Location = new System.Drawing.Point(592, 583);
            this.labelFechaAlta.Name = "labelFechaAlta";
            this.labelFechaAlta.Size = new System.Drawing.Size(0, 23);
            this.labelFechaAlta.TabIndex = 6;
            this.labelFechaAlta.UseCompatibleTextRendering = true;
            this.labelFechaAlta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(948, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 697);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(803, 590);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(87, 50);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // textBoxProxEtapa
            // 
            this.textBoxProxEtapa.Location = new System.Drawing.Point(466, 602);
            this.textBoxProxEtapa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProxEtapa.Name = "textBoxProxEtapa";
            this.textBoxProxEtapa.Size = new System.Drawing.Size(235, 26);
            this.textBoxProxEtapa.TabIndex = 9;
            // 
            // textBoxFechaAltaEtapa
            // 
            this.textBoxFechaAltaEtapa.Location = new System.Drawing.Point(640, 554);
            this.textBoxFechaAltaEtapa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFechaAltaEtapa.Name = "textBoxFechaAltaEtapa";
            this.textBoxFechaAltaEtapa.Size = new System.Drawing.Size(250, 26);
            this.textBoxFechaAltaEtapa.TabIndex = 8;
            // 
            // textBoxEtapaActual
            // 
            this.textBoxEtapaActual.Location = new System.Drawing.Point(640, 501);
            this.textBoxEtapaActual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEtapaActual.Name = "textBoxEtapaActual";
            this.textBoxEtapaActual.Size = new System.Drawing.Size(250, 26);
            this.textBoxEtapaActual.TabIndex = 7;
            // 
            // textBoxApellidoM
            // 
            this.textBoxApellidoM.Location = new System.Drawing.Point(316, 554);
            this.textBoxApellidoM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxApellidoM.Name = "textBoxApellidoM";
            this.textBoxApellidoM.Size = new System.Drawing.Size(250, 26);
            this.textBoxApellidoM.TabIndex = 6;
            // 
            // textBoxNombreM
            // 
            this.textBoxNombreM.Location = new System.Drawing.Point(315, 501);
            this.textBoxNombreM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombreM.Name = "textBoxNombreM";
            this.textBoxNombreM.Size = new System.Drawing.Size(250, 26);
            this.textBoxNombreM.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 532);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 4;
            this.label10.Tag = "";
            this.label10.Text = "Desde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 605);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 3;
            this.label9.Tag = "";
            this.label9.Text = "Ascender a Etapa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(643, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 2;
            this.label8.Tag = "";
            this.label8.Text = "Etapa Actual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 1;
            this.label7.Tag = "";
            this.label7.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 0;
            this.label6.Tag = "ccheckboxNo.Checked";
            this.label6.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 242);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PostulacionesRevisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1233, 810);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxProxEtapa);
            this.Controls.Add(this.textBoxFechaAltaEtapa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEtapaActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxApellidoM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNombreM);
            this.Controls.Add(this.labelFechaAlta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelIDProxEtapa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelIDMiembro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAprobar);
            this.Controls.Add(this.labelIDPostulacion);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PostulacionesRevisar";
            this.Text = "Postulaciones a Revisar";
            this.Load += new System.EventHandler(this.PostulacionesRevisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Label labelIDPostulacion;
        private System.Windows.Forms.Button buttonAprobar;
        private System.Windows.Forms.Label labelIDMiembro;
        private System.Windows.Forms.Label labelIDProxEtapa;
        private System.Windows.Forms.Label labelFechaAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombreM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxProxEtapa;
        private System.Windows.Forms.TextBox textBoxFechaAltaEtapa;
        private System.Windows.Forms.TextBox textBoxEtapaActual;
        private System.Windows.Forms.TextBox textBoxApellidoM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}