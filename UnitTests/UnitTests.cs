using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTD_Lab2;
using System;
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

        [TestMethod]
        public void Get_InsertFirst()
        {
            char expected = 'a';

            CircularList list = new CircularList();
            list.Insert('a', 0);

            char value = list.Get(0);

            Assert.AreEqual(expected, value);
        }


        [TestMethod]
        public void GetFirst_InsertMultiple()
        {
            char expected = 'i';

            CircularList list = new CircularList();
            list.Insert('a', 0);
            list.Insert('b', 0);
            list.Insert('c', 2);
            list.Insert('d', 1);
            list.Insert('e', 4);
            list.Insert('f', 4);
            list.Insert('g', 6);
            list.Insert('h', 7);
            list.Insert('i', 0);

            char value = list.Get(0);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetSecond_InsertMultiple()
        {
            char expected = 'd';

            CircularList list = new CircularList();
            list.Insert('a', 0);
            list.Insert('b', 0);
            list.Insert('c', 2);
            list.Insert('d', 1);
            list.Insert('e', 4);
            list.Insert('f', 4);
            list.Insert('g', 6);
            list.Insert('h', 7);

            char value = list.Get(1);

            Assert.AreEqual(expected, value);
        }
        [TestMethod]
        public void GetMiddle_InsertMultiple()
        {
            char expected = 'i';

            CircularList list = new CircularList();
            list.Insert('a', 0);
            list.Insert('b', 0);
            list.Insert('c', 2);
            list.Insert('d', 1);
            list.Insert('e', 4);
            list.Insert('f', 4);
            list.Insert('g', 6);
            list.Insert('h', 7);
            list.Insert('i', 4);

            char value = list.Get(4);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetPreLast_InsertMultiple()
        {
            char expected = 'g';

            CircularList list = new CircularList();
            list.Insert('a', 0);
            list.Insert('b', 0);
            list.Insert('c', 2);
            list.Insert('d', 1);
            list.Insert('e', 4);
            list.Insert('f', 4);
            list.Insert('g', 6);
            list.Insert('h', 7);

            char value = list.Get(6);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetLast_InsertMultiple()
        {
            char expected = 'h';

            CircularList list = new CircularList();
            list.Insert('a', 0);
            list.Insert('b', 0);
            list.Insert('c', 2);
            list.Insert('d', 1);
            list.Insert('e', 4);
            list.Insert('f', 4);
            list.Insert('g', 6);
            list.Insert('h', 7);

            char value = list.Get(7);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void Length_InsertSingle()
        {
            int expected = 1;

            CircularList list = new CircularList();
            list.Insert('a', 0);

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void Length_InsertMultiple()
        {
            int expected = 7;

            CircularList list = new CircularList();
            list.Insert('a', 0);
            list.Insert('b', 0);
            list.Insert('c', 2);
            list.Insert('d', 3);
            list.Insert('e', 3);
            list.Insert('f', 4);
            list.Insert('g', 5);

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void Length_InsertSingleAppendSingle()
        {
            int expected = 2;

            CircularList list = new CircularList();
            list.Append('a');
            list.Insert('b', 0);

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void Length_InsertMultipleAppendMultiple()
        {
            int expected = 11;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Insert('e', 0);
            list.Insert('f', 0);
            list.Insert('g', 3);
            list.Insert('h', 3);
            list.Insert('i', 4);
            list.Insert('j', 2);
            list.Insert('k', 10);

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }
    }
}