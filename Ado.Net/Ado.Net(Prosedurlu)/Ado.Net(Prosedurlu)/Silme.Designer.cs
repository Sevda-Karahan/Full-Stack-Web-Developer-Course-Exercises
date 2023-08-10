
namespace Ado.Net_Prosedurlu_
{
    partial class Silme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEvet = new System.Windows.Forms.Button();
            this.BtnHayir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "nolu öğrenciyi silmek istediğinize emin misiniz?";
            // 
            // BtnEvet
            // 
            this.BtnEvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEvet.Location = new System.Drawing.Point(87, 69);
            this.BtnEvet.Name = "BtnEvet";
            this.BtnEvet.Size = new System.Drawing.Size(77, 31);
            this.BtnEvet.TabIndex = 2;
            this.BtnEvet.Text = "Evet";
            this.BtnEvet.UseVisualStyleBackColor = true;
            this.BtnEvet.Click += new System.EventHandler(this.BtnEvet_Click);
            // 
            // BtnHayir
            // 
            this.BtnHayir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHayir.Location = new System.Drawing.Point(189, 69);
            this.BtnHayir.Name = "BtnHayir";
            this.BtnHayir.Size = new System.Drawing.Size(77, 31);
            this.BtnHayir.TabIndex = 3;
            this.BtnHayir.Text = "Hayır";
            this.BtnHayir.UseVisualStyleBackColor = true;
            this.BtnHayir.Click += new System.EventHandler(this.BtnHayir_Click);
            // 
            // Silme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 129);
            this.Controls.Add(this.BtnHayir);
            this.Controls.Add(this.BtnEvet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Silme";
            this.Text = "Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEvet;
        private System.Windows.Forms.Button BtnHayir;
        public System.Windows.Forms.Label label1;
    }
}