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
    public class OverLoadMinus
    {
        [TestMethod]
        public void PlusOverLoad_ListOfTwoSetsOfNumbers_SetsShouldMerge()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();

            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);

            listTwo.Add(2);
            listTwo.Add(1);
            listTwo.Add(6);

            string expected = "35";
            CustomList<int> actual;

            actual = listOne - listTwo;


            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void MinusOverLoad_ListOfSameNumbers_CountEqualZero()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();

            listOne.Add(2);
          
            listTwo.Add(2);

            int expected = 0;
            CustomList<int> actual;

            actual = listOne - listTwo;
            int count = actual.Count;

            Assert.AreEqual(expected, count);
        }
        [TestMethod]
        public void MinusOverLoad_HaveTwoNumbersRemovedFromSet_SetsEqual()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();

            listOne.Add(2);
            listOne.Add(4);
            listOne.Add(6);

            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(8);

            string expected = "6";
            CustomList<int> actual;

            actual = listOne - listTwo;
            

            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void PlusOverLoad_ListOfTwoSetsOfDoubles_SetsShouldMerge()
        {
            CustomList<double> listOne = new CustomList<double>();
            CustomList<double> listTwo = new CustomList<double>();

            listOne.Add(1.2);
            listOne.Add(3.2);
            listOne.Add(5.2);

            listTwo.Add(2.2);
            listTwo.Add(1.2);
            listTwo.Add(6.2);

            string expected = "3.25.2";
            CustomList<double> actual;

            actual = listOne - listTwo;


            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void PlusOverLoad_ListOfTwoSetsOfStrings_SetsShouldMerge()
        {
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();

            listOne.Add("A");
            listOne.Add("B");
            listOne.Add("C");

            listTwo.Add("E");
            listTwo.Add("A");
            listTwo.Add("F");

            string expected = "BC";
            CustomList<string> actual;

            actual = listOne - listTwo;


            Assert.AreEqual(expected, actual.ToString());
        }
    }
}
