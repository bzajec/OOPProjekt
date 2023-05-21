namespace ProjektOOP
{
    partial class WorldCup2018
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
            this.lblChooseFavouriteNation = new System.Windows.Forms.Label();
            this.cbNations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChooseFavouriteNation
            // 
            this.lblChooseFavouriteNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFavouriteNation.Location = new System.Drawing.Point(99, 83);
            this.lblChooseFavouriteNation.Name = "lblChooseFavouriteNation";
            this.lblChooseFavouriteNation.Size = new System.Drawing.Size(293, 37);
            this.lblChooseFavouriteNation.TabIndex = 0;
            this.lblChooseFavouriteNation.Text = "Izaberite najdražu naciju";
            // 
            // cbNations
            // 
            this.cbNations.FormattingEnabled = true;
            this.cbNations.Location = new System.Drawing.Point(146, 153);
            this.cbNations.Name = "cbNations";
            this.cbNations.Size = new System.Drawing.Size(178, 21);
            this.cbNations.TabIndex = 1;
            this.cbNations.SelectedIndexChanged += new System.EventHandler(this.cbNations_SelectedIndexChanged);
            // 
            // WorldCup2018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 291);
            this.Controls.Add(this.cbNations);
            this.Controls.Add(this.lblChooseFavouriteNation);
            this.Name = "WorldCup2018";
            this.Text = "WorldCup2018";
            this.Load += new System.EventHandler(this.WorldCup2018_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChooseFavouriteNation;
        private System.Windows.Forms.ComboBox cbNations;
    }
}