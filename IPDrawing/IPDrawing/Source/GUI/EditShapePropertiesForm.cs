using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Draw
{
    public partial class EditShapePropertiesForm : Form
    {
        #region Members

        Shape shape;

        #endregion

        #region Constructors

        public EditShapePropertiesForm(Shape originalShape)
        {
            InitializeComponent();
            shape = originalShape;
            EnagleOrDisableCoordinates();
        }

        #endregion

        #region Methods

        private void GetShapeProperties()
        {
            PointF location = shape.Location;
            shape.TransformMatrix.TransformPoint(ref location);
            float ofsetX = Single.Parse(tbX.Text) - location.X;
            float ofsetY = Single.Parse(tbY.Text) - location.Y;
            shape.TransformMatrix.Translate(ofsetX, ofsetY);
            shape.Width = Single.Parse(tbWidth.Text);
            shape.Height = Single.Parse(tbHeight.Text);
            shape.LineColor = btnLineColor.BackColor;
            shape.FillColor = btnFillColor.BackColor;
            shape.LineWidth = (int)numericLineWidth.Value;
        }

        private void SetShapeProperties()
        {
            tbID.Text = shape.ID.ToString();
            PointF location = shape.Location;
            shape.TransformMatrix.TransformPoint(ref location);
            tbX.Text = ((int)location.X).ToString();
            tbY.Text = ((int)location.Y).ToString();
            tbWidth.Text = shape.Width.ToString();
            tbHeight.Text = shape.Height.ToString();
            btnLineColor.BackColor = shape.LineColor;
            btnFillColor.BackColor = shape.FillColor;
            numericLineWidth.Value = shape.LineWidth;
        }

        private void EnagleOrDisableCoordinates()
        {
            if (shape.TransformMatrix.IsRotated())
            {
                tbX.Enabled = false;
                tbY.Enabled = false;
            }
            else
            {
                tbX.Enabled = true;
                tbY.Enabled = true;
            }
        }

        #endregion

        #region Event Handlers

        private void ShapePropertiesForm_Load(object sender, EventArgs e)
        {
            SetShapeProperties();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetShapeProperties();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnLineColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = shape.LineColor;
            colorDialog.ShowDialog();
            btnLineColor.BackColor = colorDialog.Color;
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = shape.FillColor;
            colorDialog.ShowDialog();
            btnFillColor.BackColor = colorDialog.Color;
        }

        #endregion
    }
}
