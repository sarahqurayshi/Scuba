
using System.Drawing;
using System.Net;

namespace Scuba
{
    internal class Rotator
    {

        private double[,] matrix = { { 0, 0 }, { 0, 0} };

        public Rotator()
        {
        }

        internal Line Rotate(Line line, int clockwiseAngleInDegrees)
        {
            double radians = clockwiseAngleInDegrees * (Math.PI / 180);

            matrix[0, 0] = Math.Cos(radians);
            matrix[0, 1] = Math.Sin(radians);
            matrix[1, 0] = -Math.Sin(radians);
            matrix[1, 1] = Math.Cos(radians);

            Point startPoint = line.GetStartPoint();
            Point endPoint = line.GetEndPoint();

            double newStartPointX = (matrix[0, 0] * startPoint.X) + (matrix[0, 1] * startPoint.Y);

            double newStartPointY = (matrix[1, 0] * startPoint.X) + (matrix[1, 1] * startPoint.Y);

            double newEndPointX = (matrix[0, 0] * endPoint.X) + (matrix[0, 1] * endPoint.Y);

            double newEndPointY = (matrix[1, 0] * endPoint.X) + (matrix[1, 1] * endPoint.Y);

            int startPointX = (int)Math.Round(newStartPointX);
            int startPointY = (int)Math.Round(newStartPointY);
            int endPointX = (int)Math.Round(newEndPointX);
            int endPointY = (int)Math.Round(newEndPointY);

            Point newStartPoint = new Point(startPointX, startPointY);
            Point newEndPoint = new Point(endPointX, endPointY);

            Line newLine = new Line(newStartPoint, newEndPoint);

            return newLine;
        }
    }
}