using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OneNumber_ToCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            list1.Add(4);
            actual = list1.Count;


            //assert

            Assert.AreEqual(expected, actual);


        }
    }
}
