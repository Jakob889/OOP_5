using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatePattern;

namespace StatePattern_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsInClosedState()
        {
            var file = new File("unittest.txt");
            Assert.IsInstanceOfType(file.State, typeof(StateClose));
        }

        [TestMethod]
        public void TestClosedToOpened()
        {
            var file = new File("unittest.txt");
            file.open();
            Assert.IsInstanceOfType(file.State, typeof(StateOpen));
        }

        [TestMethod]
        public void TestClosedToDeleted()
        {
            var file = new File("unittest.txt");
            file.delete();
            Assert.IsInstanceOfType(file.State, typeof(StateDelete));
        }

        [TestMethod]
        public void TestOpenedToClosed()
        {
            var file = new File("unittest.txt");
            file.open();
            file.close();
            Assert.IsInstanceOfType(file.State, typeof(StateClose));
        }

        [TestMethod]
        public void TestOpenedNotPossibleToDeleted()
        {
            var file = new File("unittest.txt");
            file.open();
            file.delete();
            Assert.IsNotInstanceOfType(file.State, typeof(StateDelete));
            Assert.IsInstanceOfType(file.State, typeof(StateOpen));
        }

        [TestMethod]
        public void TestDeletedNotPossibleToClosed()
        {
            var file = new File("unittest.txt");
            file.delete();
            file.close();
            Assert.IsNotInstanceOfType(file.State, typeof(StateClose));
            Assert.IsInstanceOfType(file.State, typeof(StateDelete));
        }

        [TestMethod]
        public void FileDeletedNotPossibleToOpened()
        {
            var file = new File("unittest.txt");
            file.delete();
            file.open();
            Assert.IsNotInstanceOfType(file.State, typeof(StateOpen));
            Assert.IsInstanceOfType(file.State, typeof(StateDelete));
        }

    }
}
