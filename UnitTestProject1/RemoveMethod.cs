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
    class RemoveMethod
    {
        
        [TestMethod]
        public void Remove_RemoveOnlyItemFromList_CountShouldBeZero()
        {
            CustomList<int> customList = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            customList.Add(3);
            customList.Remove(3);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveOnlyItemFromList_ItemAtFirstIndexShouldBe0()
        {
            CustomList<int> customList = new CustomList<int>();
            int expected = 0;
            int actual;

            //Act
            customList.Add(3);
            customList.Remove(3);
            actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_ReturnEqualTrue()
        {
            CustomList<int> customList = new CustomList<int>();
            bool expected = true;
            bool actual;

            //Act
            customList.Add(3);
            actual = customList.Remove(3);


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveThirdItemFromListOfFourItems_ItemThreeEqualItemFour()
        {
            CustomList<int> customList = new CustomList<int>();
            int expected = 4;
            int actual;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Remove(3);

            actual = customList[3];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromEmptyList_ReturnFalse()
        {
            CustomList<int> customList = new CustomList<int>();
            bool expected = false;
            int actual;

            //Act
           
            actual = customList.Remove(3);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemNotInList_ReturnFalse()
        {
            CustomList<int> customList = new CustomList<int>();
            bool expected = false;
            int actual;

            //Act
            customList.Add(5);
            actual = customList.Remove(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

      
    }
}
