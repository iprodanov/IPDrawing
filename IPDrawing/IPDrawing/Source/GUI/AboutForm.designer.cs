namespace Draw
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDevelopedBy = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(15, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "IPDrawing Computer Graphics Project.";
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.AutoSize = true;
            this.lblDevelopedBy.Location = new System.Drawing.Point(15, 95);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(76, 13);
            this.lblDevelopedBy.TabIndex = 1;
            this.lblDevelopedBy.Text = "Developed by:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(97, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ivan P. Prodanov";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(15, 45);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version 3.0.";
            // 
            // lblLastModified
            // 
            this.lblLastModified.AutoSize = true;
            this.lblLastModified.Location = new System.Drawing.Point(15, 70);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(155, 13);
            this.lblLastModified.TabIndex = 4;
            this.lblLastModified.Text = "Last modified: 30 October 2012";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 121);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLastModified);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDevelopedBy);
            this.Controls.Add(this.lblTitle);
            this.Name = "AboutForm";
            this.Text = "About IPDrawing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDevelopedBy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLastModified;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}