namespace ProjektOOP
{
    partial class Players
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
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbCaptain = new System.Windows.Forms.TextBox();
            this.tbPicUrl = new System.Windows.Forms.TextBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnDalje = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Location = new System.Drawing.Point(13, 13);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(310, 459);
            this.lbPlayers.TabIndex = 0;
            this.lbPlayers.SelectedIndexChanged += new System.EventHandler(this.lbPlayers_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(329, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(329, 134);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(108, 25);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "label2";
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(329, 201);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(108, 25);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label3";
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(329, 277);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(108, 25);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "label4";
            // 
            // lblCaptain
            // 
            this.lblCaptain.Location = new System.Drawing.Point(329, 382);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(108, 25);
            this.lblCaptain.TabIndex = 5;
            this.lblCaptain.Text = "label5";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(418, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 6;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(418, 131);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(169, 20);
            this.tbSurname.TabIndex = 7;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(418, 206);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(169, 20);
            this.tbNumber.TabIndex = 8;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(418, 274);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(169, 20);
            this.tbPosition.TabIndex = 9;
            // 
            // tbCaptain
            // 
            this.tbCaptain.Location = new System.Drawing.Point(418, 379);
            this.tbCaptain.Name = "tbCaptain";
            this.tbCaptain.Size = new System.Drawing.Size(169, 20);
            this.tbCaptain.TabIndex = 10;
            // 
            // tbPicUrl
            // 
            this.tbPicUrl.Location = new System.Drawing.Point(668, 379);
            this.tbPicUrl.Name = "tbPicUrl";
            this.tbPicUrl.Size = new System.Drawing.Size(284, 20);
            this.tbPicUrl.TabIndex = 11;
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(877, 421);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(75, 23);
            this.btnAddPic.TabIndex = 12;
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(877, 13);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(75, 23);
            this.btnDalje.TabIndex = 13;
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(680, 101);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(272, 272);
            this.pbPlayer.TabIndex = 14;
            this.pbPlayer.TabStop = false;
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 481);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.tbPicUrl);
            this.Controls.Add(this.tbCaptain);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbPlayers);
            this.Name = "Players";
            this.Text = "Players";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbCaptain;
        private System.Windows.Forms.TextBox tbPicUrl;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.PictureBox pbPlayer;
    }
}