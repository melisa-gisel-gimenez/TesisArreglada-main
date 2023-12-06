
namespace Iglesia
{
    partial class PPTesoreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPTesoreria));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tesoreriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarInformesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tesoreriaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(742, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tesoreriaToolStripMenuItem
            // 
            this.tesoreriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.egresosToolStripMenuItem,
            this.generarInformesToolStripMenuItem});
            this.tesoreriaToolStripMenuItem.Name = "tesoreriaToolStripMenuItem";
            this.tesoreriaToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.tesoreriaToolStripMenuItem.Text = "Tesoreria";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarIngresosToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // agregarIngresosToolStripMenuItem
            // 
            this.agregarIngresosToolStripMenuItem.Name = "agregarIngresosToolStripMenuItem";
            this.agregarIngresosToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.agregarIngresosToolStripMenuItem.Text = "Agregar Ingresos";
            this.agregarIngresosToolStripMenuItem.Click += new System.EventHandler(this.agregarIngresosToolStripMenuItem_Click);
            // 
            // egresosToolStripMenuItem
            // 
            this.egresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEgresosToolStripMenuItem});
            this.egresosToolStripMenuItem.Name = "egresosToolStripMenuItem";
            this.egresosToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.egresosToolStripMenuItem.Text = "Egresos";
            // 
            // agregarEgresosToolStripMenuItem
            // 
            this.agregarEgresosToolStripMenuItem.Name = "agregarEgresosToolStripMenuItem";
            this.agregarEgresosToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.agregarEgresosToolStripMenuItem.Text = "Agregar Egresos";
            this.agregarEgresosToolStripMenuItem.Click += new System.EventHandler(this.agregarEgresosToolStripMenuItem_Click);
            // 
            // generarInformesToolStripMenuItem
            // 
            this.generarInformesToolStripMenuItem.Name = "generarInformesToolStripMenuItem";
            this.generarInformesToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.generarInformesToolStripMenuItem.Text = "Generar Informes";
            this.generarInformesToolStripMenuItem.Click += new System.EventHandler(this.generarInformesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PPTesoreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 532);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 588);
            this.MinimumSize = new System.Drawing.Size(764, 588);
            this.Name = "PPTesoreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCD Gestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PPTesoreria_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPTesoreria_FormClosed);
            this.Load += new System.EventHandler(this.PPTesoreria_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tesoreriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarInformesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem agregarIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEgresosToolStripMenuItem;
    }
}