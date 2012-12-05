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
    public partial class ShapePropertiesForm : Form
    {
        Shape shape;

        public ShapePropertiesForm(Shape originalShape)
        {
            InitializeComponent();
            shape = originalShape;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetShape();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            return;
        }

        private void GetShape()
        {
            PointF location = shape.TransformMatrix.TransformPoint(shape.Location);
            float ofsetX = Convert.ToSingle(tbX.Text) - location.X;
            float ofsetY = Convert.ToSingle(tbY.Text) - location.Y;
            shape.TransformMatrix.Translate(ofsetX, ofsetY);
            shape.Width = Convert.ToSingle(tbWidth.Text);
            shape.Height = Convert.ToSingle(tbHeight.Text);
            shape.LineColor = btnLineColor.BackColor;
            shape.FillColor = btnFillColor.BackColor;
            shape.LineWidth = Convert.ToInt16(numericLineWidth.Value);
        }

        private void ShapePropertiesForm_Load(object sender, EventArgs e)
        {
            tbID.Text = shape.ID.ToString();
            PointF location = shape.TransformMatrix.TransformPoint(shape.Location);
            tbX.Text = Convert.ToInt16(location.X).ToString();
            tbY.Text = Convert.ToInt16(location.Y).ToString();
            tbWidth.Text = shape.Width.ToString();
            tbHeight.Text = shape.Height.ToString();
            btnLineColor.BackColor = shape.LineColor;
            btnFillColor.BackColor = shape.FillColor;
            numericLineWidth.Value = shape.LineWidth;
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

        
    }
}
