using System.Drawing;

namespace Scuba
{
    internal class Translator
    {
        int[,] matrix = { { 0, 0, 0}, { 0, 0, 0 }, { 0, 0, 0 } };
        
        public Translator()
        {
        }

        internal Point Translate(Point point, int xTrans, int yTrans)
        {
            Point newPoint = new Point();

            matrix[0, 0] = 1;
            matrix[0, 1] = 0;
            matrix[0, 2] = xTrans;
            matrix[1, 0] = 0;
            matrix[1, 1] = 1;
            matrix[1, 2] = yTrans;
            matrix[2, 0] = 0;
            matrix[2, 1] = 0;
            matrix[2, 2] = 1;

            int sum1 = (matrix[0, 0] * point.X);
            int sum2 = (matrix[0, 1] * point.Y);
            int sum3 = (matrix[0, 2] * 1);

            newPoint.X = (matrix[0, 0]* point.X) 
                + (matrix[0, 1] * point.Y) 
                + (matrix[0, 2] * 1);

            newPoint.Y = (matrix[1, 0] * point.X)
                + (matrix[1, 1] * point.Y)
                + (matrix[1, 2] * 1);

            return newPoint;
        }
    }
}