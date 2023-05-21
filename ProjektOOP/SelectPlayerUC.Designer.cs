namespace ProjektOOP
{
    partial class SelectPlayerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnAllLeft = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lbAll = new System.Windows.Forms.ListBox();
            this.lbFavorites = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(368, 228);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 13;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Location = new System.Drawing.Point(377, 100);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(75, 54);
            this.btnAllRight.TabIndex = 12;
            this.btnAllRight.Text = ">>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnAllLeft
            // 
            this.btnAllLeft.Location = new System.Drawing.Point(377, 327);
            this.btnAllLeft.Name = "btnAllLeft";
            this.btnAllLeft.Size = new System.Drawing.Size(75, 54);
            this.btnAllLeft.TabIndex = 11;
            this.btnAllLeft.Text = "<<";
            this.btnAllLeft.UseVisualStyleBackColor = true;
            this.btnAllLeft.Click += new System.EventHandler(this.btnAllLeft_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(377, 407);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 54);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(377, 24);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 54);
            this.btnRight.TabIndex = 9;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lbAll
            // 
            this.lbAll.AllowDrop = true;
            this.lbAll.FormattingEnabled = true;
            this.lbAll.Location = new System.Drawing.Point(489, 7);
            this.lbAll.Name = "lbAll";
            this.lbAll.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAll.Size = new System.Drawing.Size(330, 472);
            this.lbAll.TabIndex = 8;
            this.lbAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAll_MouseDown);
            // 
            // lbFavorites
            // 
            this.lbFavorites.AllowDrop = true;
            this.lbFavorites.FormattingEnabled = true;
            this.lbFavorites.Location = new System.Drawing.Point(7, 7);
            this.lbFavorites.Name = "lbFavorites";
            this.lbFavorites.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbFavorites.Size = new System.Drawing.Size(330, 472);
            this.lbFavorites.Sorted = true;
            this.lbFavorites.TabIndex = 7;
            this.lbFavorites.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFavorites_DragDrop);
            this.lbFavorites.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFavorites_DragEnter);
            this.lbFavorites.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbFavorites_MouseDown);
            // 
            // SelectPlayerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.btnAllLeft);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.lbFavorites);
            this.Name = "SelectPlayerUC";
            this.Size = new System.Drawing.Size(1043, 632);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnAllLeft;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.ListBox lbAll;
        private System.Windows.Forms.ListBox lbFavorites;
    }
}
