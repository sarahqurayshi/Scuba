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
            Point point = new Point(0, 0);
         
            //Act
            translator.Translate(point, 2, 2);

            //Assert
            Assert.IsTrue(point.GetX == 2);
            Assert.IsTrue(point.GetY == 2);
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
            translator.Translate(line, 2, 2);

            //Assert
            Assert.IsTrue(line.GetX1 == 2);
            Assert.IsTrue(line.GetY1 == 2);
            Assert.IsTrue(line.GetX2 == 3);
            Assert.IsTrue(line.GetY2 == 3);
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
            rotator.Rotate(line, 90);

            //Assert
            Assert.IsTrue(line.GetX1 == 0);
            Assert.IsTrue(line.GetY1 == 0);
            Assert.IsTrue(line.GetX2 == 1);
            Assert.IsTrue(line.GetY2 == -1);
        }

        [TestMethod]
        public void ReflectPointIn2D()
        {
            //Arrange
            Reflector reflector = new Reflector();
            Point pointToReflect = new Point(1, 1);
            Point lineStartPoint = new Point(-100, 0);
            Point lineEndPoint = new Point(100, 0);
            Line mirror = new Line(lineStartPoint, lineEndPoint);

            //Act
            reflector.Reflect(pointToReflect,mirror);

            //Assert
            Assert.IsTrue(pointToReflect.GetX == 1);
            Assert.IsTrue(pointToReflect.GetY == -1);
        }

        [TestMethod]
        public void ReflectLineIn2D()
        {
            //Arrange
            Reflector reflector = new Reflector();
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 2);
            Line lineToReflect = new Line(p1, p2);

            Point mirrorStartPoint = new Point(-100, 0);
            Point mirrorEndPoint = new Point(100, 0);
            Line mirror = new Line(lineStartPoint, lineEndPoint);

            //Act
            reflector.Reflect(lineToReflect, mirror);

            //Assert
            Assert.IsTrue(lineToReflect.GetX1 == 1);
            Assert.IsTrue(lineToReflect.GetY1 == -1);
            Assert.IsTrue(lineToReflect.GetX2 == 2);
            Assert.IsTrue(lineToReflect.GetY2 == -2);
        }
    }
}
