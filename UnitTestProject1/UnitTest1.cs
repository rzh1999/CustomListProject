using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProj;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public class UserName
        {
            public string name;

            public UserName()
            {
                name = "Bill";
            }
        }
        [TestMethod]
        public void AddToList_AddOneItem_ConatainItem()
        {
            //Arrange
            
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;
            int actual;

            //Act
            customList.Add(3);

            actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
