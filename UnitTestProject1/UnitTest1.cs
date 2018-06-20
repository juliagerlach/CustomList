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
        public void Add_StringCheckValue()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "hello";

            // Act
            list.Add("hello");
            string actual = list[0];

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
        public void Remove_ReturnsTrue()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            bool expected = true;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            
            bool actual = list.Remove(4);

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
            list.Remove(2);
            bool actual = list[2] == 4;

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Remove_SingleInstanceOfValue()
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
            bool actual = list[2] == 4;

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Remove_ValueNotInList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            bool expected = false;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Remove(5);

            bool actual = list.Remove(5);

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Remove_CheckValueBeyondCount()
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
            list.Remove(1);

            bool actual = list[4] == 0;

            // Assert
            Assert.IsTrue(expected == actual);
        }

        [TestMethod]
        public void Remove_StringReturnsTrue()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            bool expected = true;

            // Act
            list.Add("hello");
            list.Add("good");
            list.Add("day");
            list.Add("to you");

            bool actual = list.Remove("to you");

            // Assert
            Assert.IsTrue(expected == actual);
        }
    
        [TestMethod]
        public void ToStringOverride_ConvertIndexToString()
        {
            //Arrange
            CustomList<int> nums = new CustomList<int>();
            string expected = "2";

            // Act
            nums.Add(2);
            nums.Add(4);
            nums.Add(6);
            nums[0].ToString();
            string actual = nums[0].ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringOverride_ConvertListToString()
        {
            //Arrange
            CustomList<int> nums = new CustomList<int>();
            string expected = "246810000";

            // Act
            nums.Add(2);
            nums.Add(4);
            nums.Add(6);
            nums.Add(8);
            nums.Add(10);
            
            string actual = nums.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_CharsList()
        {
            CustomList<char> list = new CustomList<char>();
            string expected = "Mmmmm coffee";

            list.Add('M');
            list.Add('m');
            list.Add('m');
            list.Add('m');
            list.Add('m');
            list.Add(' ');
            list.Add('c');
            list.Add('o');
            list.Add('f');
            list.Add('f');
            list.Add('e');
            list.Add('e');

            string actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_StringList()
        {
            CustomList<string> list = new CustomList<string>();
            string expected = "Good day to you.";

            list.Add("Good ");
            list.Add("day ");
            list.Add("to ");
            list.Add("you.");

            string actual = list.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_NumberLists()
        {
            CustomList<int> oddNumbers = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evenNumbers = new CustomList<int>() { 2, 4, 6 };
            oddNumbers.Zip(oddNumbers, evenNumbers);
            CustomList<int> expected = new CustomList<int>();


            CustomList<int> actual = oddNumbers;


            Assert.AreEqual(expected, actual);
        }
    }
}

        
      
        
       

        
        
    
