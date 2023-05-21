namespace ProjektOOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMen = new System.Windows.Forms.PictureBox();
            this.pbWomen = new System.Windows.Forms.PictureBox();
            this.bntLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWomen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMen
            // 
            this.pbMen.Image = ((System.Drawing.Image)(resources.GetObject("pbMen.Image")));
            this.pbMen.Location = new System.Drawing.Point(12, 12);
            this.pbMen.Name = "pbMen";
            this.pbMen.Size = new System.Drawing.Size(263, 318);
            this.pbMen.TabIndex = 0;
            this.pbMen.TabStop = false;
            this.pbMen.Click += new System.EventHandler(this.pbMen_Click);
            // 
            // pbWomen
            // 
            this.pbWomen.Image = ((System.Drawing.Image)(resources.GetObject("pbWomen.Image")));
            this.pbWomen.Location = new System.Drawing.Point(531, 12);
            this.pbWomen.Name = "pbWomen";
            this.pbWomen.Size = new System.Drawing.Size(257, 318);
            this.pbWomen.TabIndex = 1;
            this.pbWomen.TabStop = false;
            this.pbWomen.Click += new System.EventHandler(this.pbWomen_Click);
            // 
            // bntLanguage
            // 
            this.bntLanguage.Location = new System.Drawing.Point(12, 415);
            this.bntLanguage.Name = "bntLanguage";
            this.bntLanguage.Size = new System.Drawing.Size(75, 23);
            this.bntLanguage.TabIndex = 2;
            this.bntLanguage.UseVisualStyleBackColor = true;
            this.bntLanguage.Click += new System.EventHandler(this.bntLanguage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntLanguage);
            this.Controls.Add(this.pbWomen);
            this.Controls.Add(this.pbMen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWomen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMen;
        private System.Windows.Forms.PictureBox pbWomen;
        private System.Windows.Forms.Button bntLanguage;
    }
}

