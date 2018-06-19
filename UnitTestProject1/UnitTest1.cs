﻿using System;
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
        public void ToStringOverride_InfoHereAboutTest()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            // Act
            

            // Assert
            
        }
    }
}
        
      
        
       

        
        
    
