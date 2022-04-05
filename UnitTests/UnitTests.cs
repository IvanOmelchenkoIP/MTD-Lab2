using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTD_Lab2;

namespace UnitTests
{
    [TestClass]
    public class CircularListTest
    {
        [TestMethod]
        public void Length_AppendSingle()
        {
            int expected = 1;

            CircularList list = new CircularList();
            list.Append('a');

            int length = list.Length();

            Assert.AreEqual(expected, length);
        }
    }
}
