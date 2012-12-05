namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineRotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newSpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.openSpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.saveSpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutSpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.copySpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.pasteSpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.deleteSpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.groupSpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.ungroupSpeedMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolsGroup = new System.Windows.Forms.GroupBox();
            this.selectionRadioButton = new System.Windows.Forms.RadioButton();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.ellipseRadioButton = new System.Windows.Forms.RadioButton();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            this.ColorsGroup = new System.Windows.Forms.GroupBox();
            this.lblLineWidth = new System.Windows.Forms.Label();
            this.numericLineWidth = new System.Windows.Forms.NumericUpDown();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblFillColor = new System.Windows.Forms.Label();
            this.lblLineColor = new System.Windows.Forms.Label();
            this.transperancyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transperancyTrackBar = new System.Windows.Forms.TrackBar();
            this.backColorLabelPanel = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ToolsGroup.SuspendLayout();
            this.ColorsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transperancyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateLeftToolStripMenuItem,
            this.rotateRightToolStripMenuItem,
            this.fineRotationToolStripMenuItem,
            this.lineColorToolStripMenuItem,
            this.changeFillColorToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // rotateLeftToolStripMenuItem
            // 
            this.rotateLeftToolStripMenuItem.Name = "rotateLeftToolStripMenuItem";
            this.rotateLeftToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.rotateLeftToolStripMenuItem.Text = "Rotate Left";
            this.rotateLeftToolStripMenuItem.Click += new System.EventHandler(this.RotateLeftToolStripMenuItem_Click);
            // 
            // rotateRightToolStripMenuItem
            // 
            this.rotateRightToolStripMenuItem.Name = "rotateRightToolStripMenuItem";
            this.rotateRightToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.rotateRightToolStripMenuItem.Text = "Rotate Right";
            this.rotateRightToolStripMenuItem.Click += new System.EventHandler(this.RotateRightToolStripMenuItem_Click);
            // 
            // fineRotationToolStripMenuItem
            // 
            this.fineRotationToolStripMenuItem.Name = "fineRotationToolStripMenuItem";
            this.fineRotationToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fineRotationToolStripMenuItem.Text = "Fine Rotation";
            this.fineRotationToolStripMenuItem.Click += new System.EventHandler(this.FineRotationToolStripMenuItem_Click);
            // 
            // lineColorToolStripMenuItem
            // 
            this.lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            this.lineColorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.lineColorToolStripMenuItem.Text = "Change Line Color";
            this.lineColorToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // changeFillColorToolStripMenuItem
            // 
            this.changeFillColorToolStripMenuItem.Name = "changeFillColorToolStripMenuItem";
            this.changeFillColorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.changeFillColorToolStripMenuItem.Text = "Change Fill Color";
            this.changeFillColorToolStripMenuItem.Click += new System.EventHandler(this.ChangeFillColorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 588);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(693, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSpeedMenu,
            this.openSpeedMenu,
            this.saveSpeedMenu,
            this.toolStripSeparator1,
            this.cutSpeedMenu,
            this.copySpeedMenu,
            this.pasteSpeedMenu,
            this.deleteSpeedMenu,
            this.groupSpeedMenu,
            this.ungroupSpeedMenu,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(693, 38);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip";
            // 
            // newSpeedMenu
            // 
            this.newSpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("newSpeedMenu.Image")));
            this.newSpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newSpeedMenu.Name = "newSpeedMenu";
            this.newSpeedMenu.Size = new System.Drawing.Size(35, 35);
            this.newSpeedMenu.Text = "New";
            this.newSpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newSpeedMenu.Click += new System.EventHandler(this.NewSpeedMenu_Click);
            // 
            // openSpeedMenu
            // 
            this.openSpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("openSpeedMenu.Image")));
            this.openSpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openSpeedMenu.Name = "openSpeedMenu";
            this.openSpeedMenu.Size = new System.Drawing.Size(40, 35);
            this.openSpeedMenu.Text = "Open";
            this.openSpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openSpeedMenu.Click += new System.EventHandler(this.OpenSpeedMenu_Click);
            // 
            // saveSpeedMenu
            // 
            this.saveSpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("saveSpeedMenu.Image")));
            this.saveSpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveSpeedMenu.Name = "saveSpeedMenu";
            this.saveSpeedMenu.Size = new System.Drawing.Size(35, 35);
            this.saveSpeedMenu.Text = "Save";
            this.saveSpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveSpeedMenu.Click += new System.EventHandler(this.SaveSpeedMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // cutSpeedMenu
            // 
            this.cutSpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("cutSpeedMenu.Image")));
            this.cutSpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutSpeedMenu.Name = "cutSpeedMenu";
            this.cutSpeedMenu.Size = new System.Drawing.Size(30, 35);
            this.cutSpeedMenu.Text = "Cut";
            this.cutSpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cutSpeedMenu.Click += new System.EventHandler(this.CutSpeedMenu_Click);
            // 
            // copySpeedMenu
            // 
            this.copySpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("copySpeedMenu.Image")));
            this.copySpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copySpeedMenu.Name = "copySpeedMenu";
            this.copySpeedMenu.Size = new System.Drawing.Size(39, 35);
            this.copySpeedMenu.Text = "Copy";
            this.copySpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.copySpeedMenu.Click += new System.EventHandler(this.CopySpeedMenu_Click);
            // 
            // pasteSpeedMenu
            // 
            this.pasteSpeedMenu.Enabled = false;
            this.pasteSpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("pasteSpeedMenu.Image")));
            this.pasteSpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteSpeedMenu.Name = "pasteSpeedMenu";
            this.pasteSpeedMenu.Size = new System.Drawing.Size(39, 35);
            this.pasteSpeedMenu.Text = "Paste";
            this.pasteSpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pasteSpeedMenu.Click += new System.EventHandler(this.PasteSpeedMenu_Click);
            // 
            // deleteSpeedMenu
            // 
            this.deleteSpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("deleteSpeedMenu.Image")));
            this.deleteSpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteSpeedMenu.Name = "deleteSpeedMenu";
            this.deleteSpeedMenu.Size = new System.Drawing.Size(44, 35);
            this.deleteSpeedMenu.Text = "Delete";
            this.deleteSpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteSpeedMenu.Click += new System.EventHandler(this.DeleteSpeedMenu_Click);
            // 
            // groupSpeedMenu
            // 
            this.groupSpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("groupSpeedMenu.Image")));
            this.groupSpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupSpeedMenu.Name = "groupSpeedMenu";
            this.groupSpeedMenu.Size = new System.Drawing.Size(44, 35);
            this.groupSpeedMenu.Text = "Group";
            this.groupSpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.groupSpeedMenu.Click += new System.EventHandler(this.GroupSpeedMenu_Click);
            // 
            // ungroupSpeedMenu
            // 
            this.ungroupSpeedMenu.Image = ((System.Drawing.Image)(resources.GetObject("ungroupSpeedMenu.Image")));
            this.ungroupSpeedMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ungroupSpeedMenu.Name = "ungroupSpeedMenu";
            this.ungroupSpeedMenu.Size = new System.Drawing.Size(58, 35);
            this.ungroupSpeedMenu.Text = "Ungroup";
            this.ungroupSpeedMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ungroupSpeedMenu.Click += new System.EventHandler(this.UngroupSpeedMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ToolsGroup);
            this.panel1.Controls.Add(this.ColorsGroup);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 503);
            this.panel1.TabIndex = 6;
            // 
            // ToolsGroup
            // 
            this.ToolsGroup.Controls.Add(this.selectionRadioButton);
            this.ToolsGroup.Controls.Add(this.rectangleRadioButton);
            this.ToolsGroup.Controls.Add(this.ellipseRadioButton);
            this.ToolsGroup.Controls.Add(this.rotateLeft);
            this.ToolsGroup.Controls.Add(this.rotateRight);
            this.ToolsGroup.Location = new System.Drawing.Point(5, 5);
            this.ToolsGroup.Name = "ToolsGroup";
            this.ToolsGroup.Size = new System.Drawing.Size(106, 74);
            this.ToolsGroup.TabIndex = 1;
            this.ToolsGroup.TabStop = false;
            this.ToolsGroup.Text = "Tools";
            // 
            // selectionRadioButton
            // 
            this.selectionRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectionRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectionRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("selectionRadioButton.Image")));
            this.selectionRadioButton.Location = new System.Drawing.Point(4, 18);
            this.selectionRadioButton.Name = "selectionRadioButton";
            this.selectionRadioButton.Size = new System.Drawing.Size(24, 24);
            this.selectionRadioButton.TabIndex = 9;
            this.selectionRadioButton.TabStop = true;
            this.selectionRadioButton.UseVisualStyleBackColor = true;
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectangleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rectangleRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleRadioButton.Image")));
            this.rectangleRadioButton.Location = new System.Drawing.Point(30, 18);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.Size = new System.Drawing.Size(24, 24);
            this.rectangleRadioButton.TabIndex = 0;
            this.rectangleRadioButton.TabStop = true;
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ellipseRadioButton
            // 
            this.ellipseRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ellipseRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ellipseRadioButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseRadioButton.Image")));
            this.ellipseRadioButton.Location = new System.Drawing.Point(56, 18);
            this.ellipseRadioButton.Name = "ellipseRadioButton";
            this.ellipseRadioButton.Size = new System.Drawing.Size(24, 24);
            this.ellipseRadioButton.TabIndex = 6;
            this.ellipseRadioButton.TabStop = true;
            this.ellipseRadioButton.UseVisualStyleBackColor = true;
            // 
            // rotateLeft
            // 
            this.rotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("rotateLeft.Image")));
            this.rotateLeft.Location = new System.Drawing.Point(4, 44);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(24, 24);
            this.rotateLeft.TabIndex = 4;
            this.rotateLeft.UseVisualStyleBackColor = true;
            this.rotateLeft.Click += new System.EventHandler(this.rotateLeft_Click);
            // 
            // rotateRight
            // 
            this.rotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rotateRight.Image = ((System.Drawing.Image)(resources.GetObject("rotateRight.Image")));
            this.rotateRight.Location = new System.Drawing.Point(30, 44);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(24, 24);
            this.rotateRight.TabIndex = 5;
            this.rotateRight.UseVisualStyleBackColor = true;
            this.rotateRight.Click += new System.EventHandler(this.rotateRight_Click);
            // 
            // ColorsGroup
            // 
            this.ColorsGroup.Controls.Add(this.lblLineWidth);
            this.ColorsGroup.Controls.Add(this.numericLineWidth);
            this.ColorsGroup.Controls.Add(this.tbHeight);
            this.ColorsGroup.Controls.Add(this.tbWidth);
            this.ColorsGroup.Controls.Add(this.lblHeight);
            this.ColorsGroup.Controls.Add(this.lblWidth);
            this.ColorsGroup.Controls.Add(this.tbY);
            this.ColorsGroup.Controls.Add(this.lblY);
            this.ColorsGroup.Controls.Add(this.tbX);
            this.ColorsGroup.Controls.Add(this.lblX);
            this.ColorsGroup.Controls.Add(this.lblFillColor);
            this.ColorsGroup.Controls.Add(this.lblLineColor);
            this.ColorsGroup.Controls.Add(this.transperancyTextBox);
            this.ColorsGroup.Controls.Add(this.label1);
            this.ColorsGroup.Controls.Add(this.transperancyTrackBar);
            this.ColorsGroup.Controls.Add(this.backColorLabelPanel);
            this.ColorsGroup.Controls.Add(this.btnBackgroundColor);
            this.ColorsGroup.Controls.Add(this.btnFillColor);
            this.ColorsGroup.Controls.Add(this.btnLineColor);
            this.ColorsGroup.Location = new System.Drawing.Point(6, 85);
            this.ColorsGroup.Name = "ColorsGroup";
            this.ColorsGroup.Size = new System.Drawing.Size(106, 400);
            this.ColorsGroup.TabIndex = 0;
            this.ColorsGroup.TabStop = false;
            this.ColorsGroup.Text = "Properties";
            // 
            // lblLineWidth
            // 
            this.lblLineWidth.AutoSize = true;
            this.lblLineWidth.Location = new System.Drawing.Point(5, 145);
            this.lblLineWidth.Name = "lblLineWidth";
            this.lblLineWidth.Size = new System.Drawing.Size(58, 13);
            this.lblLineWidth.TabIndex = 26;
            this.lblLineWidth.Text = "Line Width";
            // 
            // numericLineWidth
            // 
            this.numericLineWidth.Location = new System.Drawing.Point(64, 143);
            this.numericLineWidth.Name = "numericLineWidth";
            this.numericLineWidth.Size = new System.Drawing.Size(38, 20);
            this.numericLineWidth.TabIndex = 25;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(72, 67);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.ReadOnly = true;
            this.tbHeight.Size = new System.Drawing.Size(30, 20);
            this.tbHeight.TabIndex = 24;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(72, 42);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.ReadOnly = true;
            this.tbWidth.Size = new System.Drawing.Size(30, 20);
            this.tbWidth.TabIndex = 23;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(5, 70);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 22;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(5, 45);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 21;
            this.lblWidth.Text = "Width";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(72, 17);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(30, 20);
            this.tbY.TabIndex = 20;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(57, 20);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 19;
            this.lblY.Text = "Y";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(20, 17);
            this.tbX.Name = "tbX";
            this.tbX.ReadOnly = true;
            this.tbX.Size = new System.Drawing.Size(29, 20);
            this.tbX.TabIndex = 18;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(5, 20);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 17;
            this.lblX.Text = "X";
            // 
            // lblFillColor
            // 
            this.lblFillColor.AutoSize = true;
            this.lblFillColor.Location = new System.Drawing.Point(5, 120);
            this.lblFillColor.Name = "lblFillColor";
            this.lblFillColor.Size = new System.Drawing.Size(46, 13);
            this.lblFillColor.TabIndex = 16;
            this.lblFillColor.Text = "Fill Color";
            // 
            // lblLineColor
            // 
            this.lblLineColor.AutoSize = true;
            this.lblLineColor.Location = new System.Drawing.Point(5, 95);
            this.lblLineColor.Name = "lblLineColor";
            this.lblLineColor.Size = new System.Drawing.Size(54, 13);
            this.lblLineColor.TabIndex = 15;
            this.lblLineColor.Text = "Line Color";
            // 
            // transperancyTextBox
            // 
            this.transperancyTextBox.Location = new System.Drawing.Point(78, 202);
            this.transperancyTextBox.Name = "transperancyTextBox";
            this.transperancyTextBox.Size = new System.Drawing.Size(24, 20);
            this.transperancyTextBox.TabIndex = 11;
            this.transperancyTextBox.Text = "255";
            this.transperancyTextBox.TextChanged += new System.EventHandler(this.TransperancyTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Transperancy";
            // 
            // transperancyTrackBar
            // 
            this.transperancyTrackBar.Location = new System.Drawing.Point(5, 170);
            this.transperancyTrackBar.Maximum = 255;
            this.transperancyTrackBar.Name = "transperancyTrackBar";
            this.transperancyTrackBar.Size = new System.Drawing.Size(97, 45);
            this.transperancyTrackBar.TabIndex = 9;
            this.transperancyTrackBar.TickFrequency = 50;
            this.transperancyTrackBar.Value = 255;
            this.transperancyTrackBar.Scroll += new System.EventHandler(this.TransperancyTrackBar_Scroll);
            // 
            // backColorLabelPanel
            // 
            this.backColorLabelPanel.AutoSize = true;
            this.backColorLabelPanel.Location = new System.Drawing.Point(5, 233);
            this.backColorLabelPanel.Name = "backColorLabelPanel";
            this.backColorLabelPanel.Size = new System.Drawing.Size(59, 13);
            this.backColorLabelPanel.TabIndex = 8;
            this.backColorLabelPanel.Text = "Back Color";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(77, 228);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(25, 23);
            this.btnBackgroundColor.TabIndex = 5;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.BtnBackgroundColor_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.White;
            this.btnFillColor.Location = new System.Drawing.Point(77, 114);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(25, 25);
            this.btnFillColor.TabIndex = 3;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.BtnFillColor_Click);
            // 
            // btnLineColor
            // 
            this.btnLineColor.BackColor = System.Drawing.Color.Black;
            this.btnLineColor.Location = new System.Drawing.Point(77, 89);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(25, 25);
            this.btnLineColor.TabIndex = 2;
            this.btnLineColor.UseVisualStyleBackColor = false;
            this.btnLineColor.Click += new System.EventHandler(this.BtnLineColor_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png|Draw Vector I" +
                "mage|*.dvg";
            this.saveFileDialog.FilterIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // viewPort
            // 
            this.viewPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPort.Location = new System.Drawing.Point(116, 62);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(577, 526);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPort_Paint);
            this.viewPort.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewPort_MouseDoubleClick);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPort_MouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPort_MouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPort_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 610);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ToolsGroup.ResumeLayout(false);
            this.ColorsGroup.ResumeLayout(false);
            this.ColorsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transperancyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
        private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newSpeedMenu;
        private System.Windows.Forms.ToolStripButton openSpeedMenu;
        private System.Windows.Forms.ToolStripButton saveSpeedMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cutSpeedMenu;
        private System.Windows.Forms.ToolStripButton copySpeedMenu;
        private System.Windows.Forms.ToolStripButton pasteSpeedMenu;
        private System.Windows.Forms.ToolStripButton deleteSpeedMenu;
        private System.Windows.Forms.ToolStripButton groupSpeedMenu;
        private System.Windows.Forms.ToolStripButton ungroupSpeedMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ToolsGroup;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.RadioButton ellipseRadioButton;
        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.GroupBox ColorsGroup;
        private System.Windows.Forms.TextBox transperancyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar transperancyTrackBar;
        private System.Windows.Forms.Label backColorLabelPanel;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.RadioButton selectionRadioButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem rotateLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineRotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFillColorToolStripMenuItem;
        private System.Windows.Forms.Label lblFillColor;
        private System.Windows.Forms.Label lblLineColor;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblLineWidth;
        private System.Windows.Forms.NumericUpDown numericLineWidth;
	}
}
