using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Draw
{
    [Serializable]
    public class ShapeMatrix
    {
        #region Constructors

        public ShapeMatrix()
        {
            matrixArray = new float[6];
            matrixArray[0] = 1;
            matrixArray[1] = 0;
            matrixArray[2] = 0;
            matrixArray[3] = 1;
            matrixArray[4] = 0;
            matrixArray[5] = 0;
        }

        #endregion

        #region Properties
        
        private float[] matrixArray;

        #endregion

        #region Methods

        public Matrix GetMatrix()
        {
            return new Matrix(
                matrixArray[0],
                matrixArray[1],
                matrixArray[2],
                matrixArray[3],
                matrixArray[4],
                matrixArray[5]);
        }

        public void GetElements(Matrix transformMatrix)
        {
            matrixArray[0] = transformMatrix.Elements[0];
            matrixArray[1] = transformMatrix.Elements[1];
            matrixArray[2] = transformMatrix.Elements[2];
            matrixArray[3] = transformMatrix.Elements[3];
            matrixArray[4] = transformMatrix.Elements[4];
            matrixArray[5] = transformMatrix.Elements[5];
        }

        public void Translate(float ofsetX, float ofsetY)
        {
            Matrix transformMatrix = GetMatrix();
            transformMatrix.Translate(ofsetX, ofsetY);
            GetElements(transformMatrix);
        }

        public void RotateAt(float angle, PointF point)
        {
            Matrix transformMatrix = GetMatrix();
            transformMatrix.RotateAt(angle, point);
            GetElements(transformMatrix);
        }

        public PointF InverseTransformPoint(PointF point)
        {
            Matrix transformMatrix = GetMatrix();
            transformMatrix.Invert();
            PointF[] transformPoints = { point };
            transformMatrix.TransformPoints(transformPoints);
            return transformPoints[0];
        }

        public PointF TransformPoint(PointF point)
        {
            Matrix transformMatrix = GetMatrix();
            PointF[] transformPoints = { point };
            transformMatrix.TransformPoints(transformPoints);
            return transformPoints[0];
        }

        public void TransformPoints(PointF[] points)
        {
            Matrix transformMatrix = GetMatrix();
            transformMatrix.TransformPoints(points);
        }

        public void Multiply(ShapeMatrix groupMatrix)
        {
            Matrix m = groupMatrix.GetMatrix();
            m.Multiply(GetMatrix());
            GetElements(m);
        }

        #endregion
    }
}
