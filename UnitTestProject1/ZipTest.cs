using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProj;

namespace UnitTestProject1
{
    [TestClass]
    class ZipTest
    {
        [TestMethod]
        public void Zip_ZipIntergers_ShouldBeZipped()
        {
            //Arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();

            string expected = "123456";
            CustomList<int> actual;

            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            even.Add(2);
            even.Add(4);
            even.Add(6);

            actual = odd.Zip(even);

            Assert.AreEqual(expected, actual.ToString());

        }

        [TestMethod]
        public void Zip_ZipStrings_ShouldBeZipped()
        {
            //Arrange
            CustomList<string> stringOne = new CustomList<string>();
            CustomList<string> stringTwo = new CustomList<string>();

            string expected = "ABCDEF";
            CustomList<int> actual;

            stringOne.Add("A");
            stringOne.Add("B");
            stringOne.Add("C");

            stringTwo.Add("D");
            stringTwo.Add("E");
            stringTwo.Add("F");

            actual = stringOne.Zip(stringTwo);

            Assert.AreEqual(expected, actual.ToString());

        }
        [TestMethod]
        public void Zip_ZipStringsArgumentSetBigger_ShouldBeZipped()
        {
            //Arrange
            CustomList<string> stringOne = new CustomList<string>();
            CustomList<string> stringTwo = new CustomList<string>();

            string expected = "ADBECFGH";
            CustomList<int> actual;

            stringOne.Add("A");
            stringOne.Add("B");
            stringOne.Add("C");

            stringTwo.Add("D");
            stringTwo.Add("E");
            stringTwo.Add("F");
            stringTwo.Add("G");
            stringTwo.Add("H");

            actual = stringOne.Zip(stringTwo);

            Assert.AreEqual(expected, actual.ToString());

        }
        [TestMethod]
        public void Zip_ZipColorObjects_ShouldBeZipped()
        {
            //Arrange
            Color red = new Color("red");
            Color white = new Color("white");
            Color blue = new Color("blue");
            CustomList<Color> stringOne = new CustomList<Color>();
            CustomList<Color> stringTwo = new CustomList<Color>();

            string expected = "redwhiteblue";
            CustomList<int> actual;

            stringOne.Add(red);
            stringOne.Add(blue);

            stringTwo.Add(white);

            actual = stringOne.Zip(stringTwo);
            string actualresult = actual[0].name + actual[1].name + actual[2].name;
            Assert.AreEqual(expected, actual.ToString());

        }
        [TestMethod]
        public void Zip_ZipDoubles_ShouldBeZipped()
        {
            //Arrange
            CustomList<double> doubleOne = new CustomList<double>();
            CustomList<double> doubleTwo = new CustomList<double>();

            string expected = "1.12.13.14.15.16.1";
            CustomList<int> actual;

            doubleOne.Add(1.1);
            doubleOne.Add(3.1);
            doubleOne.Add(5.1);

            doubleTwo.Add(2.1);
            doubleTwo.Add(4.1);
            doubleTwo.Add(6.1);

            actual = doubleOne.Zip(doubleTwo);

            Assert.AreEqual(expected, actual.ToString());

        }
    }
}
