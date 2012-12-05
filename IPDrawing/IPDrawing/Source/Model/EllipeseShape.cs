using System;
using System.Drawing;

namespace Draw
{
    [Serializable]
    public class EllipseShape : Shape
    {
        #region Constructors

        public EllipseShape(RectangleF rect)
            : base(rect)
        {
            this.FillColor = Color.Red;
        }

        public EllipseShape(EllipseShape ellipese)
            : base(ellipese)
        { }

        #endregion

        #region Methods

        private bool IsPointInsideEllipse(PointF point)
        {
            PointF center = this.GetCenter();

            float x = Math.Abs(center.X - point.X);
            float y = Math.Abs(center.Y - point.Y);
            float a = (this.Width + LineWidth) / 2;
            float b = (this.Height + LineWidth) / 2;

            //Ellipse formula  
            bool result = Math.Pow(x, 2) / Math.Pow(a, 2) + Math.Pow(y, 2) / Math.Pow(b, 2) <= 1;

            return result;
        }

        public override bool Contains(PointF point)
        {
            point = TransformMatrix.InverseTransformPoint(point);
            if (base.Contains(point))
            {
                return this.IsPointInsideEllipse(point);
            }
            else
            {
                return false;
            }
        }

        public override void DrawSelf(Graphics grfx)
        {
            grfx.Transform = this.TransformMatrix.GetMatrix();
            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Transparency,FillColor)), Rectangle);
            grfx.DrawEllipse(new Pen(LineColor, LineWidth), Rectangle);
            grfx.Transform.Reset();
        }

        #endregion
    }
}
