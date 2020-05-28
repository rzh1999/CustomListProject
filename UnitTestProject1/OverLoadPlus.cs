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
    class OverLoadPlus
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
            string actual;

            actual = listOne.ToString() + listTwo.ToString();

            Assert.AreEqual(expected, actual);
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
            string actual;

            actual = listOne.ToString() + listTwo.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOverLoad_ListOfIntAndListOfString_SetsShouldMerge()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<string> listTwo = new CustomList<string>();

            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);

            listTwo.Add("one");
            listTwo.Add("two");
            listTwo.Add("three");

            string expected = "123onetwothree";
            string actual;

            actual = listOne.ToString() + listTwo.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverLoad_ListOfDoubles_SetsShouldMerge()
        {
            CustomList<double> listOne = new CustomList<double>();
            CustomList<double> listTwo = new CustomList<double>();

            listOne.Add(1.0);
            listOne.Add(2.0);
            listOne.Add(3.0);

            listTwo.Add(4.0);
            listTwo.Add(5.0);
            listTwo.Add(6.0);

            string expected = "1.02.03.04.05.06.0";
            string actual;

            actual = listOne.ToString() + listTwo.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverLoad_ListOfObjects_SetsShouldMerge()
        {
            Bill bill = new Bill();
            Hine hine = new Hine();

            CustomList<Bill> listOne = new CustomList<Bill>();
            CustomList<Hine> listTwo = new CustomList<Hine>();

            listOne.Add(bill);
            
            listTwo.Add(hine);

            string expected = bill.name + hine.name;
            string actual;

            actual = listOne[0].name.ToString() + listTwo[0].name.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
