using System;
using System.Drawing;

namespace Draw
{
    [Serializable]
    public class RectangleShape : Shape
    {
        #region Constructors
        public RectangleShape(RectangleF rect)
            : base(rect)
        {
            this.FillColor = Color.FromArgb(0, 153, 255);
        }
        
        public RectangleShape(RectangleShape rectangle)
            : base(rectangle)
        { }
        
        #endregion
        
        #region Methods
        
        public override bool Contains(PointF point)
        {
            TransformMatrix.InverseTransformPoint(ref point);
            if (base.Contains(point))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override void DrawSelf(Graphics grfx)
        {
            grfx.Transform = this.TransformMatrix.GetMatrix();
            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle);
            grfx.DrawRectangle(new Pen(LineColor, LineWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.Transform.Reset();
        }
        
        #endregion
    }
}
