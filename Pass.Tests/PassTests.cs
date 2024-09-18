using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pass.Tests
{
    [TestClass]
    public class PassTests
    {
        [TestMethod]
        public void CheckPassword_CheckNumber_1score()
        {
            // arrange
            string password = "123"; 
            var pass = new Password.Pass();
            int expected = 1; 
            // act
            int result = pass.CheckPassword(password);
            // assert
            Assert.AreEqual(expected, result);
                Console.WriteLine("1 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckStrochnih_2score()
        {
            // arrange
            string password = "pass1234";  
            var pass = new Password.Pass();
            int expected = 2;  
            // act
            int result = pass.CheckPassword(password);
            // assert
            Assert.AreEqual(expected, result);
                Console.WriteLine("2 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckZaglavnih_3score()
        {
            // arrange
            string password = "Pas1";  
            var pass = new Password.Pass();
            int expected = 3;  
            // act
            int result = pass.CheckPassword(password);
            // assert
            Assert.AreEqual(expected, result);
                Console.WriteLine("3 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckSpecialSimvols_4score()
        {
            // arrange
            string password = "Pas1!";  
            var pass = new Password.Pass();
            int expected = 4;  
            // act
            int result = pass.CheckPassword(password);
            // assert
            Assert.AreEqual(expected, result);
                Console.WriteLine("4 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckDlini_5score()
        {
            // arrange
            string password = "Password1!";  
            var pass = new Password.Pass();
            int expected = 5;  
            // act
            int result = pass.CheckPassword(password);
            // assert
            Assert.AreEqual(expected, result);
                Console.WriteLine("5 балл");
        }

        [TestMethod]
        public void CheckPassword_CheckAll_0score()
        {
            // arrange
            string password = "";   
            var pass = new Password.Pass();
            int expected = 0;
            // act
            int result = pass.CheckPassword(password);
                          pass.CheckPassword(password);
                          pass.CheckPassword(password);
                          pass.CheckPassword(password);
                          pass.CheckPassword(password);
            // assert
            Assert.AreEqual(expected, result);
                Console.WriteLine("0 балл");
        }
    }
}