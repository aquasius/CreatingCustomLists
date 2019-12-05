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
            list1.Add(1);
            actual = list1.Count;


            //assert

            Assert.AreEqual(expected, actual);


        }
    
        [TestMethod]
        public void Add_FiveNumbers_ToResizeCapacity()
        {
            //arrange
            CustomList<int> listResize = new CustomList<int>();
            int expected = 5;
            int actual;


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
            int expected = 8;
            int actual;


            //act
            listCheckIndex.Add(5);
            listCheckIndex.Add(2);
            listCheckIndex.Add(4);
            listCheckIndex.Add(8);

            actual = listCheckIndex[3];


            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Add_TenNumbersToList_CheckIndexOfFive()
        {
            CustomList<int> listCheckIndexZero = new CustomList<int>();

            //arrange
            int expected = 5;
            int actual;

            //act

            listCheckIndexZero.Add(1);
            listCheckIndexZero.Add(2);
            listCheckIndexZero.Add(3);
            listCheckIndexZero.Add(4);
            listCheckIndexZero.Add(5);
            listCheckIndexZero.Add(6);
            listCheckIndexZero.Add(7);
            listCheckIndexZero.Add(8);
            listCheckIndexZero.Add(9);
            listCheckIndexZero.Add(10);

            actual = listCheckIndexZero[4];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_EightNumbers_ConfirmIndexZero()
        {
            //arrange
            CustomList<int> listAddEight = new CustomList<int>();
            int expected = 5;
            int actual;


            //act
            listAddEight.Add(5);
            listAddEight.Add(7);
            listAddEight.Add(9);
            listAddEight.Add(10);
            listAddEight.Add(12);
            listAddEight.Add(1);
            listAddEight.Add(4);
            listAddEight.Add(6);

            actual = listAddEight[0];


            //assert
            Assert.AreEqual(expected, actual);



        }
    
    }
}
