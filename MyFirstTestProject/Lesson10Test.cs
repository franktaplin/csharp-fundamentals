using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;

namespace MyFirstTestProject
{
    [TestClass]
    public class Lesson10Test
    {
        [TestMethod]
        public void FirstName_LastName_ZipCode_Verify()
        {
            // arrange
            string firstName = "George";
            string lastName = "Washington";
            int zipCode = 64119;
            Lesson10 myLesson10 = new Lesson10(firstName, lastName, zipCode);

            // act - Nothing for this one

            // assert
            Assert.AreEqual(firstName, myLesson10.FirstName);
            Assert.AreEqual(lastName, myLesson10.LastName);
            Assert.AreEqual(zipCode, myLesson10.Zipcode);
        }

        /*
         1 .Write a test method inside the Lesson10Test.cs file. Ensure you have
         the [TestMethod] above this method. This method will be called IdVerify.
         We will be utilizing the arrange and assert portions of the AAA pattern.
         Create a variable of int called id. Provide a value for this variable.
         Create an object of Lesson 10 using the default constructor. Using the
         object created, assign the id variable to the Id property. Using an
         Assert, we are going to check to see if the id property was assigned
         properly, or if its still using the default value of 1000. Pick through
         the Assert methods to determine which would fit. There are more than 1
         possible method to test this, including the one used in the lecture.
         Run the test several times to ensure you get both a passing test and
         a failure. Ensure you provide a passing version in your checked in
         code.You only need to provide 1 Assert + method
         */
        [TestMethod]
        public void IdVerify()
        {
            int id = 2000;
            Lesson10 idTest10 = new Lesson10();
            idTest10.Id = id;

            Assert.AreEqual(id, idTest10.Id);
        }
    }


}