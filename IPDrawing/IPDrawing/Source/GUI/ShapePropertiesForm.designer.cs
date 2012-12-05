namespace Draw
{
    partial class ShapePropertiesForm
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblLineColor = new System.Windows.Forms.Label();
            this.lblFillColor = new System.Windows.Forms.Label();
            this.lblLineWidth = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.numericLineWidth = new System.Windows.Forms.NumericUpDown();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(10, 50);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(54, 50);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(10, 75);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(10, 100);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height";
            // 
            // lblLineColor
            // 
            this.lblLineColor.AutoSize = true;
            this.lblLineColor.Location = new System.Drawing.Point(117, 50);
            this.lblLineColor.Name = "lblLineColor";
            this.lblLineColor.Size = new System.Drawing.Size(54, 13);
            this.lblLineColor.TabIndex = 6;
            this.lblLineColor.Text = "Line Color";
            // 
            // lblFillColor
            // 
            this.lblFillColor.AutoSize = true;
            this.lblFillColor.Location = new System.Drawing.Point(117, 75);
            this.lblFillColor.Name = "lblFillColor";
            this.lblFillColor.Size = new System.Drawing.Size(46, 13);
            this.lblFillColor.TabIndex = 7;
            this.lblFillColor.Text = "Fill Color";
            // 
            // lblLineWidth
            // 
            this.lblLineWidth.AutoSize = true;
            this.lblLineWidth.Location = new System.Drawing.Point(117, 100);
            this.lblLineWidth.Name = "lblLineWidth";
            this.lblLineWidth.Size = new System.Drawing.Size(58, 13);
            this.lblLineWidth.TabIndex = 8;
            this.lblLineWidth.Text = "Line Width";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(23, 47);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(30, 20);
            this.tbX.TabIndex = 9;
            this.tbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(69, 47);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(30, 20);
            this.tbY.TabIndex = 10;
            this.tbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(51, 72);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(48, 20);
            this.tbWidth.TabIndex = 11;
            this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(51, 97);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(48, 20);
            this.tbHeight.TabIndex = 12;
            this.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLineColor
            // 
            this.btnLineColor.Location = new System.Drawing.Point(194, 44);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(25, 25);
            this.btnLineColor.TabIndex = 13;
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(194, 69);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(25, 25);
            this.btnFillColor.TabIndex = 14;
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // numericLineWidth
            // 
            this.numericLineWidth.Location = new System.Drawing.Point(181, 98);
            this.numericLineWidth.Name = "numericLineWidth";
            this.numericLineWidth.Size = new System.Drawing.Size(38, 20);
            this.numericLineWidth.TabIndex = 15;
            this.numericLineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(26, 22);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(27, 20);
            this.tbID.TabIndex = 16;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(24, 138);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ShapePropertiesForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(226, 174);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.numericLineWidth);
            this.Controls.Add(this.btnFillColor);
            this.Controls.Add(this.btnLineColor);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblLineWidth);
            this.Controls.Add(this.lblFillColor);
            this.Controls.Add(this.lblLineColor);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblID);
            this.Name = "ShapePropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.ShapePropertiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericLineWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblLineColor;
        private System.Windows.Forms.Label lblFillColor;
        private System.Windows.Forms.Label lblLineWidth;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.NumericUpDown numericLineWidth;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}