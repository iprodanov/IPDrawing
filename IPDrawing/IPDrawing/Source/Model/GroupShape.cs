using System;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace Draw
{
    [Serializable]
    public class GroupShape : Shape
    {
        #region Constructors

        public GroupShape(RectangleF rect)
            : base(rect)
        { }

        public GroupShape(GroupShape groupShape)
            : base(groupShape)
        { }

        #endregion

        #region Properties
        
        public override Color FillColor
        {
            get
            {
                return base.FillColor;
            }
            set
            {
                base.FillColor = value;
                foreach (var shape in Shapes)
                {
                    shape.FillColor = value;
                }
            }
        }

        public override Color LineColor
        {
            get
            {
                return base.LineColor;
            }
            set
            {
                base.LineColor = value;
                foreach (var shape in Shapes)
                {
                    shape.LineColor = value;
                }
            }
        }

        public override int LineWidth
        {
            get
            {
                return base.LineWidth;
            }
            set
            {
                base.LineWidth = value;
                foreach (var shape in Shapes)
                {
                    shape.LineWidth = value;
                }
            }
        }

        public override int Transparency
        {
            get
            {
                return base.Transparency;
            }
            set
            {
                base.Transparency = value;
                foreach (var shape in Shapes)
                {
                    shape.Transparency = value;
                }
            }
        }

        private List<Shape> shapes = new List<Shape>();
        public List<Shape> Shapes
        {
            get
            {
                return shapes;
            }

            set
            {
                shapes = value;
            }
        }

        #endregion

        #region Methods

        public override PointF[] GetCoveringRectanglePoints()
        {
            List<PointF> listOfPoints = new List<PointF>();
            foreach (var shape in Shapes)
            {
                PointF[] subPoints = shape.GetCoveringRectanglePoints();
                listOfPoints.AddRange(subPoints);
            }

            PointF[] points = listOfPoints.ToArray();
            this.TransformMatrix.TransformPoints(points);
            return points;
        }

        public override bool Contains(PointF point)
        {
            point = TransformMatrix.InverseTransformPoint(point);
            if (base.Contains(point))
            {
                foreach (var shape in Shapes)
                {
                    if (shape.Contains(point))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public override void DrawSelf(Graphics grfx)
        {
            foreach (var shape in Shapes)
            {
                Matrix original = shape.TransformMatrix.GetMatrix();
                shape.TransformMatrix.Multiply(TransformMatrix);
                shape.DrawSelf(grfx);
                shape.TransformMatrix.GetElements(original);
            }
        }

        #endregion

    }
}
