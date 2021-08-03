using NUnit.Framework;
using SafariParkApp;
using System;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {

            var subject = new Person(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);

        }


        // testcase for point3d
        [TestCase(5,6,9,5)]
        public void FeedingInputToPoint3d(int x, int y, int z, int expected) 
        {
            var testPoint = new Program.Point3d(x, y, z);
            var PointX = testPoint.x;

            Assert.AreEqual(PointX, expected);
        }

        
        

    }
}