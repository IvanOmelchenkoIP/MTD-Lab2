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
        public void GetFirst_EmptyFirst()
        {
            CircularList list = new CircularList();

            Exception exception = Assert.ThrowsException<NullReferenceException>(() => list.Get(0));
        }

        [TestMethod]
        public void GetNegative_EmptyList()
        {
            CircularList list = new CircularList();

            Exception exception = Assert.ThrowsException<NullReferenceException>(() => list.Get(-1));
        }

        [TestMethod]
        public void GetExtra_EmptyList()
        {
            CircularList list = new CircularList();

            Exception exception = Assert.ThrowsException<NullReferenceException>(() => list.Get(3));
        }

        [TestMethod]
        public void GetNegative_SingleElementList()
        {
            CircularList list = new CircularList();
            list.Append('a');

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Get(-1));
        }

        [TestMethod]
        public void GetExtra_SingleElementList()
        {
            CircularList list = new CircularList();
            list.Append('a');

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Get(3));
        }

        [TestMethod]
        public void GetNegative_MultipleElementLength()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Get(-1));
        }

        [TestMethod]
        public void GetExtra_MultipleElementLength()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Get(4));
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
        public void InsertNegative_EmptyList()
        {
            CircularList list = new CircularList();

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Insert('a', -1));
        }

        [TestMethod]
        public void InsertExtra_EmptyList()
        {
            CircularList list = new CircularList();

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Insert('a', 1));
        }

        [TestMethod]
        public void InsertNegative_SingleElementList()
        {
            CircularList list = new CircularList();
            list.Append('a');

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Insert('a', -1));
        }

        [TestMethod]
        public void InsertExtra_SingleElementList()
        {
            CircularList list = new CircularList();
            list.Append('a');

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Insert('a', 2));
        }

        [TestMethod]
        public void InsertNegative_MultipleElementList()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Insert('d', -1));
        }

        [TestMethod]
        public void InsertExtra_MultipleElementList()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            Exception exception = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Insert('d', 10));
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

        [TestMethod]
        public void AreNotSame_CloneEmpty()
        {
            CircularList list = new CircularList();
            
            CircularList clone = list.Clone();

            Assert.AreNotSame(list, clone);
        }

        [TestMethod]
        public void AreNotSame_CloneSingle()
        {
            CircularList list = new CircularList();
            list.Append('a');

            CircularList clone = list.Clone();

            Assert.AreNotSame(list, clone);
        }

        [TestMethod]
        public void AreNotSame_CloneMultiple()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            CircularList clone = list.Clone();

            Assert.AreNotSame(list, clone);
        }

        [TestMethod]
        public void Compare_CloneSingle()
        {
            CircularList list = new CircularList();
            list.Append('a');

            char expected = list.Get(0);

            CircularList clone = list.Clone();
            char value = list.Get(0);

            Assert.AreEqual(expected, value);

        }

        [TestMethod]
        public void CompareFirst_CloneMultiple()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            char expected = list.Get(0);

            CircularList clone = list.Clone();
            char value = clone.Get(0);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void CompareSecond_CloneMultiple()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');
            
            char expected = list.Get(1);

            CircularList clone = list.Clone();
            char value = clone.Get(1);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void CompareMiddle_CloneMultiple()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            char expected = list.Get(2);

            CircularList clone = list.Clone();
            char value = clone.Get(2);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void ComparePreLast_CloneMultiple()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            char expected = list.Get(3);

            CircularList clone = list.Clone();
            char value = clone.Get(3);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void CompareLast_CloneMultiple()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            char expected = list.Get(4);

            CircularList clone = list.Clone();
            char value = clone.Get(4);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void Length_CloneEmpty()
        {
            int expected = 0;

            CircularList list = new CircularList();
            CircularList clone = list.Clone();

            int length = clone.Length();

            Assert.AreEqual(expected, length);
        }
        
        [TestMethod]
        public void Length_CloneSingle()
        {
            int expected = 1;

            CircularList list = new CircularList();
            list.Append('a');

            CircularList clone = list.Clone();
            int length = clone.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void Length_CloneMultiple()
        {
            int expected = 5;
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            CircularList clone = list.Clone();
            int length = clone.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void LengthOriginal_CloneMultipleAppendToClone()
        {
            int expected = 5;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            CircularList clone = list.Clone();
            clone.Append('f');

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void LengthClone_CloneMultipleAppendToClone()
        {
            int expected = 6;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            CircularList clone = list.Clone();
            clone.Append('f');

            int length = clone.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void LengthOriginal_CloneMultipleAppendToOriginal()
        {
            int expected = 6;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            CircularList clone = list.Clone();

            list.Append('f');

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void LengthClone_CloneMultipleAppendToOriginal()
        {
            int expected = 5;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            CircularList clone = list.Clone();

            list.Append('f');

            int length = clone.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void CompareLength_CloneEmpty()
        {
            CircularList list = new CircularList();
            int expected = list.Length();

            CircularList clone = list.Clone();
            int length = clone.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void CompareLength_CloneSingle()
        {
            CircularList list = new CircularList();
            list.Append('a');

            int expected = list.Length();

            CircularList clone = list.Clone();
            int length = clone.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void CompareLength_CloneMultiple()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            int expected = list.Length();

            CircularList clone = list.Clone();
            int length = clone.Length();

            Assert.AreEqual(expected, length);
        }

        [TestMethod]
        public void CompareLength_CloneMultipleAppendToClone()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');

            int expected = list.Length();

            CircularList clone = list.Clone();
            clone.Append('f');

            int length = clone.Length();

            Assert.AreNotEqual(expected, length);
        }

        [TestMethod]
        public void CompareLength_CloneMultipleAppendToOriginal()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            list.Append('e');


            CircularList clone = list.Clone();
            
            list.Append('f');
            int expected = list.Length();

            int length = clone.Length();

            Assert.AreNotEqual(expected, length);
        }

        [TestMethod]
        public void Compare_CloneEmptyAppendToBothSame()
        {
            CircularList list = new CircularList();
            CircularList clone = list.Clone();

            list.Append('a');
            clone.Append('b');

            char expected = list.Get(0);
            char value = clone.Get(0);

            Assert.AreNotEqual(expected, value);
        }

        [TestMethod]
        public void Compare_CloneEmptyAppendToBothDifferent()
        {
            CircularList list = new CircularList();
            CircularList clone = list.Clone();

            list.Append('a');
            clone.Append('a');

            char expected = list.Get(0);
            char value = clone.Get(0);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void Compare_CloneMultipleInsertToClone()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            CircularList clone = list.Clone();
            clone.Insert('d', 1);

            char expected = list.Get(1);
            char value = clone.Get(1);

            Assert.AreNotEqual(expected, value);
        }

        [TestMethod]
        public void Compare_CloneMultipleInsertToOriginal()
        {
            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            CircularList clone = list.Clone();

            list.Insert('d', 1);

            char expected = list.Get(1);
            char value = clone.Get(1);

            Assert.AreNotEqual(expected, value);
        }

        [TestMethod]
        public void GetOriginalMiddle_CloneMultipleInsertToClone()
        {
            char expected = 'b';

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            CircularList clone = list.Clone();
            clone.Insert('d', 1);

            char value = list.Get(1);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetCloneMiddle_CloneMultipleInsertToClone()
        {
            char expected = 'd';

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            CircularList clone = list.Clone();
            clone.Insert('d', 1);

            char value = clone.Get(1);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetOriginalMiddle_CloneMultipleInsertToOriginal()
        {
            char expected = 'd';

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            CircularList clone = list.Clone();
            
            list.Insert('d', 1);

            char value = list.Get(1);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void GetCloneMiddle_CloneMultipleInsertToOriginal()
        {
            char expected = 'b';

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            CircularList clone = list.Clone();
            
            list.Insert('d', 1);

            char value = clone.Get(1);

            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void FindLast_EmptyList()
        {
            int expected = -1;

            CircularList list = new CircularList();

            int index = list.FindLast('a');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindLast_OneElement()
        {
            int expected = 0;

            CircularList list = new CircularList();
            list.Append('b');

            int index = list.FindLast('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindLast_TwoElementsSame()
        {
            int expected = 2;

            CircularList list = new CircularList();
            list.Append('b');
            list.Append('b');
            list.Append('b');

            int index = list.FindLast('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindLast_SingleSuitableFirst()
        {
            int expected = 0;

            CircularList list = new CircularList();
            list.Append('b');
            list.Append('a');
            list.Append('c');

            int index = list.FindLast('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindLast_SingleSuitableMiddle()
        {
            int expected = 2;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('c');
            list.Append('b');
            list.Append('d');

            int index = list.FindLast('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindLast_SingleSuitableLast()
        {
            int expected = 3;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('c');
            list.Append('d');
            list.Append('b');

            int index = list.FindLast('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindLast_MultipleSuitableLast()
        {
            int expected = 4;

            CircularList list = new CircularList();
            list.Append('b');
            list.Append('a');
            list.Append('c');
            list.Append('a');
            list.Append('b');

            int index = list.FindLast('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindLast_MultipleSuitableMiddle()
        {
            int expected = 2;

            CircularList list = new CircularList();
            list.Append('b');
            list.Append('c');
            list.Append('b');
            list.Append('a');
            list.Append('w');

            int index = list.FindLast('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindLast_NoSuitable()
        {
            int expected = -1;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('c');
            list.Append('a');

            int index = list.FindLast('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_EmptyList()
        {
            int expected = -1;

            CircularList list = new CircularList();

            int index = list.FindFirst('a');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_OneElement()
        {
            int expected = 0;

            CircularList list = new CircularList();
            list.Append('b');

            int index = list.FindFirst('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_TwoElementsSame()
        {
            int expected = 0;

            CircularList list = new CircularList();
            list.Append('b');
            list.Append('b');

            int index = list.FindFirst('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_SingleSuitableFirst()
        {
            int expected = 0;

            CircularList list = new CircularList();
            list.Append('b');
            list.Append('a');
            list.Append('c');

            int index = list.FindFirst('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_SingleSuitableMiddle()
        {
            int expected = 2;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('c');
            list.Append('b');
            list.Append('d');

            int index = list.FindFirst('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_SingleSuitableLast()
        {
            int expected = 3;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('c');
            list.Append('d');
            list.Append('b');

            int index = list.FindFirst('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_MultipleSuitableFirst()
        {
            int expected = 0;

            CircularList list = new CircularList();
            list.Append('b');
            list.Append('a');
            list.Append('c');
            list.Append('a');
            list.Append('b');

            int index = list.FindFirst('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_MultipleSuitableMiddle()
        {
            int expected = 2;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('c');
            list.Append('b');
            list.Append('a');
            list.Append('b');

            int index = list.FindFirst('b');

            Assert.AreEqual(expected, index);
        }

        [TestMethod]
        public void FindFirst_NoSuitable()
        {
            int expected = -1;

            CircularList list = new CircularList();
            list.Append('a');
            list.Append('c');
            list.Append('a');

            int index = list.FindFirst('b');

            Assert.AreEqual(expected, index);
        }


    }
}