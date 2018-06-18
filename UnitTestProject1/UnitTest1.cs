using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_CountGoesUp()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            // Act
            list.Add(6);
            int actual = list.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CapacityChanges()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 8;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            int actual = list.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckIndexLocation()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 6;

            // Act
            list.Add(6);
            int actual = list[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckValue()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 6;

            // Act
            list.Add(6);
            int actual = list[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddMultipleCheckLastIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 10;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            int actual = list[9];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CountGoesDown()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            bool expected = true;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(4);
            bool actual = list.Count == 3;

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Remove_CheckValueAtEndOfList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            bool expected = true;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Remove(4);
            bool actual = list[4] == 6;

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Remove_CheckValueWithinList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            bool expected = true;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Remove(4);
            bool actual = list[2] == 3;

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Remove_ValueCheckCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            bool expected = true;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(3);
            list.Add(5);
            list.Add(3);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Remove(3);
            bool actual = list.Count == 9;

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Remove_MultipleCheckCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            bool expected = true;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Remove(4);
            list.Remove(5);
            list.Remove(6);
            list.Remove(7);
            bool actual = list.Count == 8;

            // Assert
            Assert.IsTrue(expected == actual);
        }
    }
}
        
      
        
       
//            List<int> numbers = new List<int>();
//            count = 3;
//            capacity = 4;
//            numbers[0] = 1;
//            numbers[1] = 2;
//            numbers[2] = 3;
            
//            if (count == capacity)
//            {capacity += 4;
//            int[] myList = new int[capacity];

//            for (int i = 0; i<count; i++)
//            {
//            newList[i] = myList[i];
//            }

//            myList = newList;
//            myList[count] = item;
//            count++;

//            else
//            {
//            myList[count] = item;
//            count++;
//            }
//actualResult = Console.WriteLine[3]; }
        
        
        
//            //Assert - test that data gets added to the correct 
//            Assert.AreEqual(expectedResult, actualResult); 
//       }
//}
