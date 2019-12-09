using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListCreation;
namespace CustomListUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OneNumber_ToCount()
        {
            //arrange
            CustomLists<int> list1 = new CustomLists<int>();
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
            CustomLists<int> listResize = new CustomLists<int>();
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
            CustomLists<int> listCheckIndex = new CustomLists<int>();
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
            CustomLists<int> listCheckIndexZero = new CustomLists<int>();

            //arrange
            int expected = 6;
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

            actual = listCheckIndexZero[5];
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_EightNumbers_ConfirmIndexZero()
        {
            //arrange
            CustomLists<int> listAddEight = new CustomLists<int>();
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

        [TestMethod]
        public void Add_ThreeNumbers_RemoveIndexTwo()
        {
            //Arrange
            CustomLists<int> listRemoveIndex2 = new CustomLists<int>();
            int expected = 2;
            int actual;


            //Act
            listRemoveIndex2.Add(1);
            listRemoveIndex2.Add(2);
            listRemoveIndex2.Add(3);
            listRemoveIndex2.Remove(3);

            actual = listRemoveIndex2.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

       
       
        [TestMethod]
        public void Add_SevenNumbers_RemoveTwoNumbers_CheckCount()
        {
            //Arrange
            CustomLists<int> listAdd7Count = new CustomLists<int>();
            int expected = 5;
            int actual;


            //Act
            listAdd7Count.Add(1);
            listAdd7Count.Add(2);
            listAdd7Count.Add(3);
            listAdd7Count.Add(4);
            listAdd7Count.Add(5);
            listAdd7Count.Add(6);
            listAdd7Count.Add(7);
            listAdd7Count.Remove(4);
            listAdd7Count.Remove(5);

            actual = listAdd7Count.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Add_SevenNumbers_Remove_TwoNumbers_CheckIndexThree()
        {
            //Arrange
            CustomLists<int> listAdd7CheckIndex3 = new CustomLists<int>();
            int expected = 6;
            int actual;

            //Act
            listAdd7CheckIndex3.Add(1);
            listAdd7CheckIndex3.Add(2);
            listAdd7CheckIndex3.Add(3);
            listAdd7CheckIndex3.Add(4);
            listAdd7CheckIndex3.Add(5);
            listAdd7CheckIndex3.Add(6);
            listAdd7CheckIndex3.Add(7);
            listAdd7CheckIndex3.Remove(1);
            listAdd7CheckIndex3.Remove(2);

            actual = listAdd7CheckIndex3[3];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Item_ThatDoesntExist()
        {
            //Arrange
            CustomLists<bool> listRemoveFakeNumber = new CustomLists<bool>();
            bool expected = false;
            bool actual;

            //Act
            listRemoveFakeNumber.Remove(true);

            actual = false;

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Add_Number_Remove_Number_CheckIndexZero()
        {
            //Arrange
            CustomLists<int> listAddRemove = new CustomLists<int>();
            int expected = 0;
            int actual;

            //Act
            listAddRemove.Add(1);
            listAddRemove.Remove(1);

            actual = listAddRemove.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_TwoStrings()
        {
            //Arrange
            CustomLists<string> listAddTwoStrings = new CustomLists<string>();
            string expected = "MilwaukeeBucks";
            string actual;

            //Act
            listAddTwoStrings.Add("Milwaukee");
            listAddTwoStrings.Add("Bucks");
            actual = listAddTwoStrings.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoStrings_RemoveString()
        {
            //Arrange
            CustomLists<string> listAddRemoveString = new CustomLists<string>();
            string expected = "Coding";
            string actual;

            //Act
            listAddRemoveString.Add("Computer");
            listAddRemoveString.Add("Coding");
            listAddRemoveString.Remove("Computer");

            actual = listAddRemoveString.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_FourStrings_CheckCount()
        {
            //Arrange
            CustomLists<string> listAddFour = new CustomLists<string>();
            string expected = "OneTwoThreeFour";
            string actual;

            //Act
            listAddFour.Add("One");
            listAddFour.Add("Two");
            listAddFour.Add("Three");
            listAddFour.Add("Four");

            actual = listAddFour.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
