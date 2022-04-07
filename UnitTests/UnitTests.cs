
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTD_Lab2;

namespace UnitTests
{
    [TestClass]
    public class CircularListTest
    {

        [TestMethod]
        public void Get_AppendSingle()
        {
            char expected = 'a';

            CircularList list = new CircularList();
            list.Append('a');

            char value = list.Get(0);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetFirst_AppendMultiple()
        {
            char expected = 'a';

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            char value = list.Get(0);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetMiddle_AppendMultiple()
        {
            char expected = 'd';

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            char value = list.Get(3);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetLast_AppendMultiple()
        {
            char expected = 'e';

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            char value = list.Get(4);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void Length_EmptyList()
        {
            int expected = 0;

            CircularList list = new CircularList();

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void Length_AppendSingle()
        {
            int expected = 1;

            CircularList list = new CircularList();
            list.Append('a');

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void Length_AppendMultiple()
        {
            int expected = 5;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }
    }
}