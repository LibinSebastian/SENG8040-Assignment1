using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SENG8040_Assignment_1;

namespace RectangleTests
{
    [TestFixture]
    class RectangleTests
    {
        [Test]
        //Test 1: Test for getting the Length.
        public void GetLen_InputLenght12_expectedLength12()
        {
            //Arrange
            int LenOf = 12;
            int WidOf = 9;
            Rect RecTest = new Rect(LenOf, WidOf);

            //Act
            int len = RecTest.GetLen();

            //Assert
            Assert.AreEqual(LenOf, len);
        }
        [Test]
        //Test 2: Test for getting the Width.
        public void GetWid_InputWidth8_expectedWidth8()
        {
            //Arrange
            int LenOf = 6;
            int WidOf = 8;
            Rect RecTest = new Rect(LenOf, WidOf);

            //Act
            int wid = RecTest.GetWid();

            //Assert
            Assert.AreEqual(WidOf, wid);
        }
        [Test]
        //Test 3: Test for checking the Perimeter.
        public void GetPeri_InputLength5andWidth7_expectedPerimeter24()
        {
            //Arrange
            int LenOf = 5;
            int WidOf = 7;
            int expectedPerimeter = 24;
            Rect RecTest = new Rect(LenOf, WidOf);
            
            //Act
            int peri = RecTest.GetPeri();

            //Assert
            Assert.AreEqual(expectedPerimeter, peri);
        }
        [Test]
        //Test 4: Testing for checking the Perimeter.
        public void GetPeri_InputLength13andWidth12_expectedPerimeter50()
        {
            //Arrange
            int LenOf = 13;
            int WidOf = 12;
            int expectedPerimeter = 50;
            Rect RecTest = new Rect(LenOf, WidOf);

            //Act
            int peri = RecTest.GetPeri();

            //Assert
            Assert.AreEqual(expectedPerimeter, peri);


        }
        [Test]
        //Test 5: Testing for checking the Area.
        public void GetArea_InputLength10andWidth12_expectedArea120()
        {
            //Arrange
            int LenOf = 10;
            int WidOf = 12;
            int expectedArea = 120;
            Rect RecTest = new Rect(LenOf, WidOf);

            //Act
            int area = RecTest.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, area);


        }
        [Test]
        //Test 6: Testing for checking the Area.
        public void GetArea_InputLength32andWidth21_expectedArea672()
        {
            //Arrange
            int LenOf = 32;
            int WidOf = 21;
            int expectedArea = 672;
            Rect RecTest = new Rect(LenOf, WidOf);

            //Act
            int area = RecTest.GetArea();

            //Assert
            Assert.AreEqual(expectedArea, area);


        }
        [Test]
        //Test 7: Test for getting the Length.
        public void GetLen_InputLenght9_expectedLength9()
        {
            //Arrange
            int LenOf = 9;
            int WidOf = 12;
            Rect RecTest = new Rect(LenOf, WidOf);

            //Act
            int len = RecTest.GetLen();

            //Assert
            Assert.AreEqual(LenOf, len);
        }
        [Test]
        //Test 8: Test for getting the Width.
        public void GetWid_InputWidth18_expectedWidth18()
        {
            //Arrange
            int LenOf = 4;
            int WidOf = 18;
            Rect RecTest = new Rect(LenOf, WidOf);

            //Act
            int wid = RecTest.GetWid();

            //Assert
            Assert.AreEqual(WidOf, wid);
        }

        [Test]
        //Test 9: Test for Setting Length.
        public void SetLen_Input6andChangeto5_expectedLength5()
        {
            //Arrange
            int LenOf = 6;
            int LenChange = 5;
            int expectedLength = 5;
            Rect RectTest = new Rect(LenOf, LenChange);

            //Act
            int len = RectTest.SetLen(expectedLength);

            //Assert
            Assert.AreEqual(LenChange, expectedLength);
        }
        [Test]
        //Test 10: Test for Setting Length.
        public void SetLen_Input16andChangeto19_expectedLength19()
        {
            //Arrange
            int LenOf = 16;
            int LenChange = 19;
            int expectedLength = 19;
            Rect RectTest = new Rect(LenOf, LenChange);

            //Act
            int len = RectTest.SetLen(expectedLength);

            //Assert
            Assert.AreEqual(LenChange, expectedLength);
        }
        [Test]
        //Test 11: Test for Setting Width.
        public void SetWid_InputWidth12andChangeto13_expectedWidth13()
        {
            //Arrange
            int WidOf = 12;
            int WidChange = 13;
            int expectedWid = 13;
            Rect RectTest = new Rect(WidOf, WidChange);

            //Act
            int wid = RectTest.SetWid(expectedWid);

            //Assert
            Assert.AreEqual(WidChange, expectedWid);
        }
        [Test]
        //Test 12: Test for Setting Width.
        public void SetWid_InputWidth2andChangeto21_expectedWidth21()
        {
            //Arrange
            int WidOf = 2;
            int WidChange = 21;
            int expectedWid = 21;
            Rect RectTest = new Rect(WidOf, WidChange);

            //Act
            int wid = RectTest.SetWid(expectedWid);

            //Assert
            Assert.AreEqual(WidChange, expectedWid);
        }

    }
}
