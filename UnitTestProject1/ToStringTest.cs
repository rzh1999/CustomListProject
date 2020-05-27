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

            string expectedBill = "Bill";
            string actual1;

            string expectedNeeds = "needs";
            string actual2;

            string expectedMore = "more";
            string actual3;

            string expectedWork = "work";
            string actual4;

            actual1 = customList.ToString();
            actual2 = customList.ToString();
            actual3 = customList.ToString();
            actual4 = customList.ToString();

            Assert.AreEqual(actual1, expectedBill);
            Assert.AreEqual(actual2, expectedNeeds);
            Assert.AreEqual(actual3, expectedMore);
            Assert.AreEqual(actual4, expectedWork);
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
    }
}
