using System;
using System.Collections.Generic;
using System.Text;

namespace MTD_Lab2
{
    public class CharNode
    {
        public CharNode next;
        public char value;
    }

    public class CircularList
    {
        public CharNode head = null;
        private int length = 0;

        public int Length() 
        {
            return 0;
        }

        public void Append(char element)
        {

        }

        public void Insert(char element, int index)
        { 

        }

        public char Delete(int index)
        {
            return '0';
        }

        public void DeleteAll(char element)
        {

        }

        public char Get(int index)
        {
            return '0';
        }

        public CircularList Clone()
        {
            return null;
        }

        public void Reverse()
        {

        }

        public int FindFirst(char element)
        {
            return -1;
        }

        public int FindLast(char element)
        {
            return -1;
        }

        public void Clear()
        {

        }

        public void Extend(CircularList list)
        {

        }
    }
}
