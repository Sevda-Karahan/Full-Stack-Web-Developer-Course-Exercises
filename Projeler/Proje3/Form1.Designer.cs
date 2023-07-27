
namespace Proje3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonVersiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayakkabılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.formalarToolStripMenuItem,
            this.ayakkabılarToolStripMenuItem,
            this.toplarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // formalarToolStripMenuItem
            // 
            this.formalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klasikToolStripMenuItem,
            this.sonVersiyonToolStripMenuItem});
            this.formalarToolStripMenuItem.Name = "formalarToolStripMenuItem";
            this.formalarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.formalarToolStripMenuItem.Text = "Formalar";
            // 
            // klasikToolStripMenuItem
            // 
            this.klasikToolStripMenuItem.Name = "klasikToolStripMenuItem";
            this.klasikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.klasikToolStripMenuItem.Text = "Klasik";
            this.klasikToolStripMenuItem.Click += new System.EventHandler(this.klasikToolStripMenuItem_Click);
            // 
            // sonVersiyonToolStripMenuItem
            // 
            this.sonVersiyonToolStripMenuItem.Name = "sonVersiyonToolStripMenuItem";
            this.sonVersiyonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sonVersiyonToolStripMenuItem.Text = "Son Versiyon";
            // 
            // ayakkabılarToolStripMenuItem
            // 
            this.ayakkabılarToolStripMenuItem.Name = "ayakkabılarToolStripMenuItem";
            this.ayakkabılarToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ayakkabılarToolStripMenuItem.Text = "Ayakkabılar";
            // 
            // toplarToolStripMenuItem
            // 
            this.toplarToolStripMenuItem.Name = "toplarToolStripMenuItem";
            this.toplarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.toplarToolStripMenuItem.Text = "Toplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "BEŞİKTAŞ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje3.Properties.Resources.BesiktasJK_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(94, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonVersiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayakkabılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

