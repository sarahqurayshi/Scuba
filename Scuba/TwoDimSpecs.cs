using System.Drawing;
using System.Security.Cryptography;

namespace Scuba
{
    [TestClass]
    public sealed class TwoDimSpecs
    {
        [TestMethod]
        public void TranslatePointIn2D()
        {
            //Arrange
            Translator translator = new Translator();
            Point originalPoint = new Point(0, 0);
            Point newPoint;

            //Act
            newPoint = translator.Translate(originalPoint, 2, 2);

            //Assert
            Assert.IsTrue(newPoint.X == 2);
            Assert.IsTrue(newPoint.Y == 2);
        }

        [TestMethod]
        public void TranslateLineIn2D()
        {
            //Arrange
            Translator translator = new Translator();
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 1);
            Line line = new Line(p1, p2);

            //Act
            Line newLine = translator.Translate(line, 2, 2);
            Point newStartPoint = newLine.GetStartPoint();
            Point newEndPoint = newLine.GetEndPoint();

            //Assert
            Assert.IsTrue(newStartPoint.X == 2);
            Assert.IsTrue(newStartPoint.Y == 2);
            Assert.IsTrue(newEndPoint.X == 3);
            Assert.IsTrue(newEndPoint.Y == 3);
        }

        [TestMethod]
        public void RotateLineIn2D()
        {
            //Arrange
            Rotator rotator = new Rotator();
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 1);
            Line line = new Line(p1, p2);

            //Act
            Line newLine = rotator.Rotate(line, 90);
            Point newStartPoint = newLine.GetStartPoint();
            Point newEndPoint = newLine.GetEndPoint();

            //Assert
            Assert.IsTrue(newStartPoint.X == 0);
            Assert.IsTrue(newStartPoint.Y == 0);
            Assert.IsTrue(newEndPoint.X == 1);
            Assert.IsTrue(newEndPoint.Y == -1);
        }

        //[TestMethod]
        //public void ReflectPointIn2D()
        //{
        //    //Arrange
        //    Reflector reflector = new Reflector();
        //    Point pointToReflect = new Point(1, 1);
        //    Point lineStartPoint = new Point(-100, 0);
        //    Point lineEndPoint = new Point(100, 0);
        //    Line mirror = new Line(lineStartPoint, lineEndPoint);

        //    //Act
        //    reflector.Reflect(pointToReflect,mirror);

        //    //Assert
        //    Assert.IsTrue(pointToReflect.X == 1);
        //    Assert.IsTrue(pointToReflect.Y == -1);
        //}

        //[TestMethod]
        //public void ReflectLineIn2D()
        //{
        //    //Arrange
        //    Reflector reflector = new Reflector();
        //    Point p1 = new Point(1, 1);
        //    Point p2 = new Point(2, 2);
        //    Line lineToReflect = new Line(p1, p2);

        //    Point mirrorStartPoint = new Point(-100, 0);
        //    Point mirrorEndPoint = new Point(100, 0);
        //    Line mirror = new Line(lineStartPoint, lineEndPoint);

        //    //Act
        //    reflector.Reflect(lineToReflect, mirror);

        //    //Assert
        //    Assert.IsTrue(lineToReflect.GetX1 == 1);
        //    Assert.IsTrue(lineToReflect.GetY1 == -1);
        //    Assert.IsTrue(lineToReflect.GetX2 == 2);
        //    Assert.IsTrue(lineToReflect.GetY2 == -2);
        //}
    }
}
