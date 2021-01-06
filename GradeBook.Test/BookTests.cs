using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GradeBook.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
       
        public void TestMethod1()
        {

            // arrange
            var book = new Book("");

            // act

            book.AddGrade(79.9);
            // assert
            Assert.AreEqual()
        }
    }
}
