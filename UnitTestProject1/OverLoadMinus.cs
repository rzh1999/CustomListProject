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
    }
}
