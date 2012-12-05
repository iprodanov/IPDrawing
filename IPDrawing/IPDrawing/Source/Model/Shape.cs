using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    [Serializable]
    public abstract class Shape
    {
        #region Members

        private int id;
        private RectangleF rectangle;
        private Color fillColor;
        private Color lineColor;
        private int lineWidth;
        private int transparency;
        private ShapeMatrix transformMatrix;

        #endregion

        #region Constructors

        public Shape()
        {
        }
		
	    public Shape(RectangleF rect)
	    {
		    this.LineColor = Color.Black;
		    this.FillColor = Color.White;
		    this.LineWidth = 2;
		    this.Transparency = 255;
		    this.Rectangle = rect;
		    this.TransformMatrix = new ShapeMatrix();
	    }

	    public Shape(Shape shape)
	    {
		    this.Height = shape.Height;
		    this.Width = shape.Width;
		    this.Location = shape.Location;
		    this.Rectangle = shape.rectangle;
			
		    this.FillColor =  shape.FillColor;
		    this.LineColor = shape.LineColor;
		    this.LineWidth = shape.LineWidth;
		    this.TransformMatrix = shape.TransformMatrix;
	    }
		
        #endregion
		
	    #region Properties
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
		
	    public virtual RectangleF Rectangle
        {
		    get { return rectangle; }
		    set { rectangle = value; }
	    }
		
	    public virtual float Width
        {
		    get { return Rectangle.Width; }
		    set 
		    {
                	if (value > 0)
			        {
                        rectangle.Width = value;
                	}
            }
	    }
		
	    public virtual float Height
        {
		    get { return Rectangle.Height; }
		    set
            {
                if (value > 0)
                {
                    rectangle.Height = value;
                }
            }
	    }
		
	    public virtual PointF Location
        {
		    get { return Rectangle.Location; }
		    set { rectangle.Location = value; }
	    }
		
	    public virtual Color FillColor
        {
		    get { return fillColor; }
		    set { fillColor = value; }
	    }

        public virtual Color LineColor
        {
		    get { return lineColor; }
		    set { lineColor = value; }
        }

        public virtual int LineWidth
        {
		    get { return lineWidth; }
		    set 
		    {
			    if (value > 0)
			    {
				    lineWidth = value;
			    }
		    }
        }

        public virtual int Transparency
        {
        	get { return transparency; }
		    set
		    {
			    if (value >= 0 && value <= 255)
			    {
				    transparency = value;
			    }
		    }
        }

        public virtual ShapeMatrix TransformMatrix
        {
		    get { return transformMatrix; }
	        set { transformMatrix = value; }
        }

	    #endregion

        #region Methods

        public virtual PointF GetCenter()
        {
            	float ofsetX = this.Width / 2;
            	float ofsetY = this.Height / 2;
            	PointF center = new PointF(this.Location.X + ofsetX, this.Location.Y + ofsetY);
            
            	return center;
        }

        public virtual PointF[] GetCoveringRectanglePoints()
        { 
		PointF[] points = 
                	{
	                    	new PointF (this.Rectangle.X, this.Rectangle.Y),
        	            	new PointF (this.Rectangle.X + this.Width, this.Rectangle.Y),
                	    	new PointF (this.Rectangle.X, this.Rectangle.Y + this.Height),
                    		new PointF (this.Rectangle.X + this.Width, this.Rectangle.Y + this.Height)
                	};
            	this.TransformMatrix.TransformPoints(points);
            
            	return points;
        }

        public bool IsGroup()
        {
            	return (this.GetType().ToString() == "Draw.GroupShape");
        }

        public virtual bool Contains(PointF point)
	{
		RectangleF rect = Rectangle;
            	rect.Inflate(LineWidth / 2, LineWidth / 2);
            	return rect.Contains(point);
	}
		
	public abstract void DrawSelf(Graphics grfx);

        #endregion
    }
}
