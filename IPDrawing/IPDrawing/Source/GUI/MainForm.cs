using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace Draw
{
	public partial class MainForm : Form
    {
        #region Members

        private DialogProcessor dialogProcessor;

        #endregion

        #region Constructors

        public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            dialogProcessor = new DialogProcessor();
		}

        #endregion

        #region ViewPort Workspace Events

        private void ViewPort_Paint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }

        private void ViewPort_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            dialogProcessor.StartPoint = e.Location;
            Shape shape = dialogProcessor.ContainsPoint(e.Location);
                
            if (shape != null)
            {
                ClickOnShape(shape);
                LoadShapeProperties(shape);
            }
            else
            {
                ClickOnWorkspace();                    
            }

            viewPort.Invalidate();
		}

        private void ViewPort_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Shape shape = dialogProcessor.ContainsPoint(e.Location);
            EditShapeProperties(shape);
        }

		private void ViewPort_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            dialogProcessor.EndPoint = e.Location;
            
            if (IsDragging())
            {
                DraggingShape();
                SetXY();
			}
            else if (IsDrawing())
            {
                DrawingShape();
            }
            
            viewPort.Invalidate();
		}

		private void ViewPort_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{   
            if(dialogProcessor.TempShape != null)
            {
                dialogProcessor.AddTempShapeToShapes();
            }

            ResetFlags();

            viewPort.Invalidate();
		}

        private void ViewPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int count = dialogProcessor.Selection.Count;
                if (count > 0)
                {
                    EditShapeProperties(dialogProcessor.Selection[count - 1]);
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }
            else if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.C)
            {
                Copy();
            }
            else if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.V)
            {
                Paste();
            }
            else if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.X)
            {
                Cut();
            }
            else if (e.KeyCode == Keys.S)
            {
                Save();
            }
            else if ((ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.S)
            {
                SaveAs();
            }
            else if (e.KeyCode == Keys.R)
            {
                Rotate(45);
            }
            else if (e.KeyCode == Keys.L)
            {
                Rotate(-45);
            }
            else if (e.KeyCode == Keys.G)
            {
                GroupShapes();
            }
            else if (e.KeyCode == Keys.U)
            {
                UngroupShape();
            }

        }

        #endregion

        #region Tools & Properties

        private void rotateRight_Click(object sender, EventArgs e)
        {
            Rotate(45);
        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            Rotate(-45);
        }

        private void BtnLineColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = btnLineColor.BackColor;
            btnLineColor.BackColor = PickColor();
            ChangeLineColor();
        }

        private void BtnFillColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = btnFillColor.BackColor;
            btnFillColor.BackColor = PickColor();
            ChangeFillColor();
        }

        private void BtnBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = btnBackgroundColor.BackColor;
            btnBackgroundColor.BackColor = PickColor();
            viewPort.BackColor = btnBackgroundColor.BackColor;
            dialogProcessor.IsChanged = true;
        }

        private void TransperancyTrackBar_Scroll(object sender, EventArgs e)
        {
            transperancyTextBox.Text = transperancyTrackBar.Value.ToString();
            ChangeColorTransparancy();
        }

        private void TransperancyTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = transperancyTextBox.Text;
            if (input != string.Empty && IsValueInRange(Convert.ToInt16(transperancyTextBox.Text), 0, 255))
            {
                transperancyTrackBar.Value = Convert.ToInt16(transperancyTextBox.Text);
            }
            ChangeColorTransparancy();
        }

        private void numericLineWidth_ValueChanged(object sender, EventArgs e)
        {
            ChangeLineWidth();
        }

        #endregion

        #region Speed Menu

        private void NewSpeedMenu_Click(object sender, EventArgs e)
        {
            NewSheet();
        }

        private void OpenSpeedMenu_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                OpenFile();
        }

        private void SaveSpeedMenu_Click(object sender, EventArgs e)
        {
            Save();
        }
        
        private void CutSpeedMenu_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void CopySpeedMenu_Click(object sender, EventArgs e)
        {
            Copy();
        }
        
        private void PasteSpeedMenu_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void DeleteSpeedMenu_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void GroupSpeedMenu_Click(object sender, EventArgs e)
        {
            GroupShapes();
        }

        private void UngroupSpeedMenu_Click(object sender, EventArgs e)
        {
            UngroupShape();
        }

        #endregion

        #region File Menu

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSheet();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                OpenFile();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Edit Menu

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        #endregion
        
        #region Image Menu

        private void RotateLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(-90);
        }

        private void RotateRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotate(90);
        }

        private void FineRotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FineRotationForm frmFineRotation = new FineRotationForm();
            if (frmFineRotation.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int value = frmFineRotation.GetAngle();
                if (IsValueInRange(value, -180, 180))
                {
                    Rotate(value);
                }
            }
        }

        private void LineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.Color = btnLineColor.BackColor;
            btnLineColor.BackColor = PickColor();
            ChangeLineColor();
        }

        private void ChangeFillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.Color = btnFillColor.BackColor;
            btnFillColor.BackColor = PickColor();
            ChangeFillColor();
        }

        #endregion

        #region Help Menu

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.Show();
        }

        #endregion
        
        #region Methods

        private void ClickOnShape(Shape shape)
        {
            statusBar.Items[0].Text = "Last action: Click on shape";

            if ((ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (dialogProcessor.Selection.Contains(shape))
                {
                    RemoveFromSelection(shape);
                }
                else
                {
                    AddToSelection(shape);
                }
            }
            else
            {
                dialogProcessor.Selection.Clear();
                AddToSelection(shape);
            }

            dialogProcessor.IsDragging = true;
        }

        private void SetXY()
        {
            if (dialogProcessor.Selection.Count > 0)
            {
                Shape shape = dialogProcessor.Selection[0];
                PointF location = shape.Location;
                shape.TransformMatrix.TransformPoint(ref location);
                tbX.Text = ((int)location.X).ToString();
                tbY.Text = ((int)location.Y).ToString();
            }
        }

        private void LoadShapeProperties(Shape shape)
        {
            SetXY();
            tbWidth.Text = shape.Width.ToString();
            tbHeight.Text = shape.Height.ToString();
            btnLineColor.BackColor = shape.LineColor;
            btnFillColor.BackColor = shape.FillColor;
            numericLineWidth.Value = shape.LineWidth;
            transperancyTextBox.Text = shape.Transparency.ToString();
            transperancyTrackBar.Value = shape.Transparency;
        }

        private void RemoveFromSelection(Shape shape)
        {
            dialogProcessor.Selection.Remove(shape);
        }

        private void AddToSelection(Shape shape)
        {
            dialogProcessor.Selection.Add(shape);
        }

        private void ClickOnWorkspace()
        {
            statusBar.Items[0].Text = "Last action: Click on workspace";
            dialogProcessor.Selection.Clear();
            if (selectionRadioButton.Checked)
            {
                dialogProcessor.IsSelecting = true;
            }
            else
            {
                dialogProcessor.IsDrawing = true;
            }
        }

        private bool IsDragging()
        {
            return dialogProcessor.IsDragging;
        }

        private void DraggingShape()
        {
            statusBar.Items[0].Text = "Last action: Dragging shape";
            dialogProcessor.Translate();
        }

        private bool IsDrawing()
        {
            return dialogProcessor.IsDrawing;
        }

        private void DrawingShape()
        {
            if (rectangleRadioButton.Checked)
            {
                statusBar.Items[0].Text = "Last action: Drawing rectangle";
                dialogProcessor.AddRectangle();
            }
            else if (ellipseRadioButton.Checked)
            {
                statusBar.Items[0].Text = "Last action: Drawing ellipse";
                dialogProcessor.AddEllipse();
            }
        }

        private void Rotate(float angle)
        {
            if (dialogProcessor.Selection != null)
            {
                dialogProcessor.Rotate(angle);
                viewPort.Invalidate();
            }
        }

        private void GroupShapes()
        {   
            dialogProcessor.GroupShapes();
            viewPort.Invalidate();
        }

        private void UngroupShape()
        {
            dialogProcessor.UngroupShape();
            viewPort.Invalidate();
        }

        private void EditShapeProperties(Shape shape)
        {
            if (shape != null)
            {
                EditShapePropertiesForm frmEditShapePropertiesForm = new EditShapePropertiesForm(shape);
                if (frmEditShapePropertiesForm.ShowDialog() == DialogResult.OK)
                {
                    LoadShapeProperties(shape);
                }
            }
        }

        private void ResetFlags()
        {
            dialogProcessor.IsDragging = false;
            dialogProcessor.IsDrawing = false;
            dialogProcessor.IsSelecting = false;
        }

        private void Save()
        {
            if (saveFileDialog.FileName == "")
                SaveAs();
            else
                SaveToFile();
        }

        private void SaveAs()
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                SaveToFile();
        }

        private void SaveToFile()
        {
            switch (saveFileDialog.FilterIndex)
            {
                case 1: SaveAsJPEG(); break;
                case 2: SaveAsBMP(); break;
                case 3: SaveAsGIF(); break;
                case 4: SaveAsPNG(); break;
                case 5: SaveAsNativeFileType(); break;
            }
            dialogProcessor.IsChanged = false;
        }

        private Bitmap CreateImage()
        {
            Bitmap image = new Bitmap(viewPort.Width, viewPort.Height);
            viewPort.DrawToBitmap(image, new Rectangle(0, 0, viewPort.Width, viewPort.Height));
            return image;
        }

        private void SaveAsJPEG()
        {
            Bitmap image = CreateImage();
            image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void SaveAsBMP()
        {
            Bitmap image = CreateImage();
            image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void SaveAsGIF()
        {
            Bitmap image = CreateImage();
            image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
        }

        private void SaveAsPNG()
        {
            Bitmap image = CreateImage();
            image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void SaveAsNativeFileType()
        {
            Serialize();
        }

        private void Serialize()
        {
            FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, dialogProcessor.Shapes);
            fileStream.Flush();
            fileStream.Close();
        }

        private void OpenFile()
        {
            Deserialize();
            dialogProcessor.Selection.Clear();
            saveFileDialog.FileName = openFileDialog.FileName;
            viewPort.Invalidate();
        }

        private void Deserialize()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            dialogProcessor.Shapes = (List<Shape>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
        }

        private void NewSheet()
        {
            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Save();
            }
            else if (result == DialogResult.No)
            {
                SelectAll();
                Delete();
                saveFileDialog.FileName = string.Empty;
                DisplayProcessor.shapeNumber = 0;
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void Cut()
        {
            if (dialogProcessor.Selection.Count > 0)
            {
                Copy();
                dialogProcessor.RemoveSelectionFromShapes();
                dialogProcessor.Selection.Clear();
                viewPort.Invalidate();
            }
        }

        private void Copy()
        {
            if (dialogProcessor.Selection.Count > 0)
            {
                Clipboard.SetData("DVG", dialogProcessor.Selection);
                pasteSpeedMenu.Enabled = true;
                pasteToolStripMenuItem.Enabled = true;
            }
        }

        private void Paste()
        {
            if (Clipboard.ContainsData("DVG"))
            {
                dialogProcessor.Selection.Clear();
                dialogProcessor.Selection = (List<Shape>)Clipboard.GetData("DVG");
                dialogProcessor.AddSelectionToShapes();
                Clipboard.Clear();
                pasteSpeedMenu.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;
                viewPort.Invalidate();
            }
        }

        private void Delete()
        {
            dialogProcessor.RemoveSelectionFromShapes();
            dialogProcessor.Selection.Clear();
            viewPort.Invalidate();
        }

        private void SelectAll()
        {
            dialogProcessor.Selection.Clear();
            dialogProcessor.Selection.AddRange(dialogProcessor.Shapes);
            viewPort.Invalidate();
        }

        private Color PickColor()
        {
            colorDialog.ShowDialog();
            return colorDialog.Color;
        }

        private void ChangeLineColor()
        {
            Color color = btnLineColor.BackColor;
            dialogProcessor.ChangeLineColor(color);
            viewPort.Invalidate();
        }

        private void ChangeFillColor()
        {
            Color color = btnFillColor.BackColor;
            dialogProcessor.ChangeFillColor(color);
            viewPort.Invalidate();
        }

        private void ChangeColorTransparancy()
        {
            int transparency = transperancyTrackBar.Value;
            dialogProcessor.ChangeColorTransparency(transparency);
            viewPort.Invalidate();
        }

        private void ChangeLineWidth()
        {
            int value = Convert.ToInt16(numericLineWidth.Value);
            dialogProcessor.ChangeLineWidth(value);
            viewPort.Invalidate();
        }

        private bool IsValueInRange(int value, int min, int max)
        {
            return (value >= min && value <= max);
        }

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dialogProcessor.IsChanged)
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    Save();
                    if (dialogProcessor.IsChanged)
                    {
                        e.Cancel = true;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
