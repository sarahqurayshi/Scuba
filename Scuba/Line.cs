using System.Drawing;

namespace Scuba
{
    internal class Line
    {
        private Point p1;
        private Point p2;

        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public Point GetEndPoint()
        {
            return p2;
        }

        public Point GetStartPoint()
        {
            return p1;
        }
    }
}