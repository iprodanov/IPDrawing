using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Draw
{
    
    public class DisplayProcessor
	{
		#region Constructor
		
		public DisplayProcessor()
		{
            shapeList = new List<Shape>();
		}
		
		#endregion
		
		#region Properties

        private List<Shape> shapeList;		
		public List<Shape> Shapes
        {
			get
            {
                return shapeList;
            }
			
            set
            {
                shapeList = value;
            }
		}

        private Shape tempShape;
        public virtual Shape TempShape
        {
            get
            {
                return tempShape;
            }

            set
            {
                tempShape = value;
            }
        }

        public static int shapeNumber;
        
		
		#endregion
		
		#region Drawing
		
		public void ReDraw(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Draw(e.Graphics);
		}
		
		public virtual void Draw(Graphics grfx)
		{
            foreach (Shape shape in Shapes)
            {
				DrawShape(grfx, shape);
			}

            if (TempShape != null)
            {
                DrawShape(grfx, TempShape);
            }
		}
		
		public virtual void DrawShape(Graphics grfx, Shape item)
		{
			item.DrawSelf(grfx);
		}
		
		#endregion
	}
}
