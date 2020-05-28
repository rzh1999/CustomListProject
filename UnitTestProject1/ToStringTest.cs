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
    public class ToStringTest
    {
        [TestMethod]
        public void Tostring_OneString_StringEquals()
        {
            CustomList<string> customList = new CustomList<string>();

            customList.Add("Bill");

            string expected = "Bill";
            string actual;

            actual = customList.ToString();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Tostring_FourStrings_AllStringsEqual()
        {
            CustomList<string> customList = new CustomList<string>();

            customList.Add("Bill");
            customList.Add("needs");
            customList.Add("more");
            customList.Add("work");

            string expected = "Billneedsmorework";
            string actual;


            actual = customList.ToString();


            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Tostring_NullString_StringEqualsNull()
        {
            CustomList<string> customList = new CustomList<string>();

            string nullTest = null;

            customList.Add(nullTest);

            string expected = null;
            string actual;

            actual = customList.ToString();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Tostring_ThreeNumbers_StringsEqual()
        {
            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
           

            string expected = "123";
            string actual;


            actual = customList.ToString();


            Assert.AreEqual(actual, expected);
        }
    }
}

