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
    public class IEnumerableTest
    {
        [TestMethod]
        public void IEnumerable_ForEachLoopToSumIntergers_SumEqualTen()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 10;
            int actual =0;

            //Act
            customList.Add(5);
            customList.Add(3);
            customList.Add(2);

            for (int i =0; i < customList.Count; i++)
            {
                actual += customList[i];
            }

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
