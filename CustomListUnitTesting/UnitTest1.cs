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
    
        [TestMethod]
        public void Add_FiveNumbers_ToResizeCapacity()
        {
            //arrange
            CustomList<int> listResize = new CustomList<int>();
            int expected = 7;
            int actual;

            int number1 = 2;
            int number2 = 4;
            int number3 = 6;
            int number4 = 8;
            int number5 = 10;


            //act

            listResize.Add(2);
            listResize.Add(4);
            listResize.Add(6);
            listResize.Add(8);
            listResize.Add(10);

            actual = listResize.Count;



            //assert

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void Check_WhatsAtIndexThree()
        {
            //arrange
            CustomList<int> listCheckIndex = new CustomList<int>();
            int expected = 4;
            int actual;


            //act
            listCheckIndex.Add(5);
            listCheckIndex.Add(2);
            listCheckIndex.Add(4);
            listCheckIndex.Add(8);

            actual = listCheckIndex.Count;


            //assert
            Assert.AreEqual(expected, actual);


        }
    
    
    
    
    
    }
}
