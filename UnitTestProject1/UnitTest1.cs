﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProj;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void Add_AddOneItem_ConatainItemInPosition0()
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

        [TestMethod]
        public void Add_AddTwoItemsGetCount_CountShouldEqualTwo()
        {
            //Arrange

            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            customList.Add(3);
            customList.Add(4);

            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

       

    }
}
