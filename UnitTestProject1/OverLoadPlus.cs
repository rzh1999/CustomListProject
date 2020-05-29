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
    public class OverLoadPlus
    {
        [TestMethod]
        public void PlusOverLoad_ListOfTwoSetsOfNumbers_SetsShouldMerge()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();

            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);

            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);

            string expected = "123456";
            CustomList<int> actual;

            actual = listOne + listTwo;


            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void PlusOverLoad_ListOfTwoSetsOfNumbers_CountShouldEqualSix()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();

            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);

            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);

            int expected = 6;
            CustomList<int> actual;

            actual = listOne + listTwo;
            int count = actual.Count;

            Assert.AreEqual(expected, count);
        }
        [TestMethod]
        public void PlusOverLoad_ListOfTwoSetsOfStrings_SetsShouldMerge()
        {
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();

            listOne.Add("1");
            listOne.Add("2");
            listOne.Add("3");

            listTwo.Add("4");
            listTwo.Add("5");
            listTwo.Add("6");

            string expected = "123456";
            CustomList<string> actual;

            actual = listOne + listTwo;

            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void PlusOverLoad_ListOfDoubles_SetsShouldMerge()
        {
            CustomList<double> listOne = new CustomList<double>();
            CustomList<double> listTwo = new CustomList<double>();

            listOne.Add(1.3);
            listOne.Add(2.3);
            listOne.Add(3.3);

            listTwo.Add(4.3);
            listTwo.Add(5.3);
            listTwo.Add(6.3);

            string expected = "1.32.33.34.35.36.3";
            CustomList<double> actual;

            actual = listOne + listTwo;

            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void PlusOverLoad_ListOfObjects_SetsShouldMerge()
        {
            Bill bill = new Bill();
            Bill hine = new Bill();

            CustomList<Bill> listOne = new CustomList<Bill>();
            CustomList<Bill> listTwo = new CustomList<Bill>();

            listOne.Add(bill);

            listTwo.Add(hine);

            string expected = bill.name + hine.name;
            CustomList<Bill> actual;

            actual = listOne + listTwo;
            string actualResult = actual[0].name + actual[1].name;

            Assert.AreEqual(expected, actualResult.ToString());
        }
        [TestMethod]
        public void PlusOverLoad_ListOfChars_SetsShouldMerge()
        {
            CustomList<char> listOne = new CustomList<char>();
            CustomList<char> listTwo = new CustomList<char>();

            listOne.Add('q');
            listOne.Add('u');
            listOne.Add('a');
            listOne.Add('r');

            listTwo.Add('k');

            string expected = "quark";
            CustomList<char> actual;

            actual = listOne + listTwo;


            Assert.AreEqual(expected, actual.ToString());
        }
    }
}
