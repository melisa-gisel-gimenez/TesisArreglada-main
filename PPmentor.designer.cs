
namespace Iglesia
{
    partial class PPmentor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPmentor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mentoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reunionesDeMentoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postulacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeMentoreadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentoresToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(663, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mentoresToolStripMenuItem
            // 
            this.mentoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reunionesDeMentoriasToolStripMenuItem,
            this.postulacionesToolStripMenuItem});
            this.mentoresToolStripMenuItem.Name = "mentoresToolStripMenuItem";
            this.mentoresToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.mentoresToolStripMenuItem.Text = "Mentores";
            // 
            // reunionesDeMentoriasToolStripMenuItem
            // 
            this.reunionesDeMentoriasToolStripMenuItem.Name = "reunionesDeMentoriasToolStripMenuItem";
            this.reunionesDeMentoriasToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.reunionesDeMentoriasToolStripMenuItem.Text = "Reuniones de mentorias";
            this.reunionesDeMentoriasToolStripMenuItem.Click += new System.EventHandler(this.reunionesDeMentoriasToolStripMenuItem_Click);
            // 
            // postulacionesToolStripMenuItem
            // 
            this.postulacionesToolStripMenuItem.Name = "postulacionesToolStripMenuItem";
            this.postulacionesToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.postulacionesToolStripMenuItem.Text = "Postulaciones de miembros";
            this.postulacionesToolStripMenuItem.Click += new System.EventHandler(this.postulacionesToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMentoreadosToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // listaDeMentoreadosToolStripMenuItem
            // 
            this.listaDeMentoreadosToolStripMenuItem.Name = "listaDeMentoreadosToolStripMenuItem";
            this.listaDeMentoreadosToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.listaDeMentoreadosToolStripMenuItem.Text = "Lista de Mentoreados";
            this.listaDeMentoreadosToolStripMenuItem.Click += new System.EventHandler(this.listaDeMentoreadosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PPmentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 433);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(681, 480);
            this.MinimumSize = new System.Drawing.Size(681, 480);
            this.Name = "PPmentor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCD Gestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PPmentor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPmentor_FormClosed);
            this.Load += new System.EventHandler(this.PPmentor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mentoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reunionesDeMentoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postulacionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeMentoreadosToolStripMenuItem;
    }
}