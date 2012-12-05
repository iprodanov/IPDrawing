using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace Draw
{
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
            selection = new List<Shape>();
		}
		
		#endregion
		
		#region Properties
		
        private List<Shape> selection;
		public List<Shape> Selection
        {
			get
            {
                return selection;
            }
            set
            {
                selection = value;
            }
		}
		
		private bool isDragging;
		public bool IsDragging
        {
			get
            {
                return isDragging;
            }
            set
            {
                isDragging = value;
            }
		}

        private bool isDrawing;
        public bool IsDrawing
        {
            get
            {
                return isDrawing;
            }
            set
            {
                isDrawing = value;
            }
        }

        private bool isSelecting;
        public bool IsSelecting
        {
            get
            {
                return isSelecting;
            }

            set
            {
                isSelecting = value;
            }
        }

        private bool isChanged;
        public bool IsChanged
        {
            get
            {
                return isChanged;
            }
            set
            {
                isChanged = value;
            }
        }

		private PointF startPoint;
		public PointF StartPoint
        {
			get
            {
                return startPoint;
            }
            set
            {
                startPoint = value;
            }
		}

        private PointF endPoint;
        public PointF EndPoint
        {
            get
            {
                return endPoint;
            }
            set
            {
                endPoint = value;
            }
        }

        #endregion

        #region Methods

        private RectangleShape CreateRectangleShape()
        {
            RectangleF rect = GetSelectionRectangleBounds();
            return new RectangleShape(rect);
        }

        private EllipseShape CreateEllipseShape()
        {
            RectangleF rect = GetSelectionRectangleBounds();
            return new EllipseShape(rect);
        }

        private GroupShape CreateGroupShape()
        {
            SetStartEndPoints();
            RectangleF rect = GetSelectionRectangleBounds();
            GroupShape group =  new GroupShape(rect);
            GroupAllSelectedShapes(group);
            return group;
        }

        private RectangleShape CreateFrame(Shape shape)
        {
            RectangleF rect = shape.Rectangle;
            byte frameOffset = 5;
            float frameMargin = shape.LineWidth / 2 + frameOffset;
            rect.Inflate(frameMargin, frameMargin);

            RectangleShape frame = new RectangleShape(rect);
            frame.LineWidth = 2;
            frame.LineColor = Color.Black;
            frame.Transparency = 0;
            return frame;
        }

        public void AddRectangle()
        {
            TempShape = CreateRectangleShape();
        }

        public void AddEllipse()
        {
            TempShape = CreateEllipseShape();
        }

        public void GroupShapes()
        {
            if (Selection.Count > 0)
            {
                GroupShape group = CreateGroupShape();
                Selection.Add(group);
                AddShape(group);
            }
        }

        public void AddTempShapeToShapes()
        {
            if (TempShape != null)
            {
                AddShape(TempShape);
            }
            TempShape = null;
        }
        
        private void AddShape(Shape shape)
        {
            shapeNumber++;
            shape.ID = shapeNumber;
            IsChanged = true;
            Shapes.Add(shape);
        }

        public void RemoveSelectionFromShapes()
        {
            foreach (var shape in Selection)
            {
                Shapes.Remove(shape);
            }
        }

        public void AddSelectionToShapes()
        {   
            foreach (var shape in Selection)
            {
                Shapes.Add(shape);
            }
            SortCollectionByShapeID(Shapes);
        }

        public void ChangeFillColor(Color color)
        {
            foreach (var shape in Selection)
            {
                shape.FillColor = color;
                IsChanged = true;
            }
        }

        public void ChangeLineColor(Color color)
        {   
            foreach (var shape in Selection)
            {
                shape.LineColor = color;
                IsChanged = true;
            }
        }

        public void ChangeColorTransparency(int value)
        {   
            foreach (var shape in Selection)
            {
                shape.Transparency = value;
                IsChanged = true;
            }
        }

        public void ChangeLineWidth(int width)
        {   
            foreach (var shape in Selection)
            {
                //width in px
                shape.LineWidth = width;
                IsChanged = true;
            }
        }

        public Shape ContainsPoint(PointF point)
        {
            for (int i = Shapes.Count - 1; i >= 0; i--)
            {
                if (Shapes[i].Contains(point))
                {
                    return Shapes[i];
                }
            }
            return null;
        }
        
        public void Translate()
		{   
            foreach (var shape in Selection)
            {
                Matrix m = new Matrix();
                m.Translate(EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
                m.Multiply(shape.TransformMatrix.GetMatrix());
                shape.TransformMatrix.GetElements(m);
                IsChanged = true;
            }
            StartPoint = EndPoint;
        }

        public void Rotate(float angle)
        {
            foreach (var shape in Selection)
            {
                shape.TransformMatrix.RotateAt(angle, shape.GetCenter());
                IsChanged = true;
            }
        }

        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);
            DrawFrame(grfx);
        }

        private void DrawFrame(Graphics grfx)
        {
            foreach (var shape in Selection)
            {
                RectangleShape frame = CreateFrame(shape);
                Pen pen = new Pen(frame.LineColor, frame.LineWidth);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                grfx.Transform = shape.TransformMatrix.GetMatrix();
                grfx.DrawRectangle(pen, frame.Location.X, frame.Location.Y, frame.Width, frame.Height);
                grfx.Transform.Reset();
            }
        }

        private RectangleF GetSelectionRectangleBounds()
        {
            PointF location = GetSelectionRectangleLocation();
            SizeF size = GetSelectionRectangleSize();

            return new RectangleF(location, size);
        }
        
        private PointF GetSelectionRectangleLocation()
        {
            PointF location = new PointF();
            location.X = Math.Min(StartPoint.X, EndPoint.X);
            location.Y = Math.Min(StartPoint.Y, EndPoint.Y);

            return location;
        }

        private SizeF GetSelectionRectangleSize()
        {
            SizeF size = new SizeF();
            size.Width = Math.Abs(StartPoint.X - EndPoint.X);
            size.Height = Math.Abs(StartPoint.Y - EndPoint.Y);
            return size;
        }

        private void SetStartEndPoints()
        {
            float minX = 10000;
            float minY = 10000;
            float maxX = - 10000;
            float maxY = -10000;
            
            foreach (var shape in Selection)
            {
                PointF[] points = shape.GetCoveringRectanglePoints();
                
                foreach (var point in points)
                {
                    minX = Math.Min(minX, point.X);
                    minY = Math.Min(minY, point.Y);
                    maxX = Math.Max(maxX, point.X);
                    maxY = Math.Max(maxY, point.Y);
                }
            }

            StartPoint = new PointF(minX, minY);
            EndPoint = new PointF(maxX, maxY);
        }

        public void UngroupShape()
        {
            for (int i = Selection.Count - 1; i >= 0; i--)
            {
                if (Selection[i].IsGroup())
                {
                    RestoreShapesFromGroup((GroupShape)Selection[i]);
                    RemoveGroup((GroupShape)Selection[i]);
                    SortCollectionByShapeID(Selection);
                    SortCollectionByShapeID(Shapes);
                    IsChanged = true;
                }
            }
        }

        private void GroupAllSelectedShapes(GroupShape group)
        {
            foreach (var shape in Selection)
            {
                group.Shapes.Add(shape);
                Shapes.Remove(shape);
            }
            Selection.Clear();
            SortCollectionByShapeID(group.Shapes);
        }

        private void RestoreShapesFromGroup(GroupShape group)
        {
            foreach (var shape in group.Shapes)
            {
                shape.TransformMatrix.Multiply(group.TransformMatrix);
                Selection.Add(shape);
                Shapes.Add(shape);
            }
        }

        private void RemoveGroup(GroupShape group)
        {
            Selection.Remove(group);
            Shapes.Remove(group);
        }
        
        private void SortCollectionByShapeID(List<Shape> list)
        {
            Shape shape;
            for(int i = 0; i <= list.Count-2; i++)
                for (int j = list.Count - 1; j >= i; j--)
                    if (list[j].ID < list[i].ID)
                    {
                        shape = list[i];
                        list[i] = list[j];
                        list[j] = shape;
                    }
        }
        
        #endregion
    }
}
