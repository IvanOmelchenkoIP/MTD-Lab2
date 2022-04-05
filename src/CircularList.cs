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
            return length;
        }

        public void Append(char element)
        {
            if (head == null)
            {
                CharNode head = new CharNode();
                head.value = element;
                head.next = head;

                length++;
                return;
            }

            CharNode current = head;
            while(true)
            {
                if (current.next == head)
                {
                    CharNode tail = new CharNode();

                    tail.value = element;
                    tail.next = head;
                    current.next = tail;

                    length++;
                    return;
                }
                current = current.next;
            }
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
            int counter = 0;
            CharNode current = head;
            while (true)
            {
                if (counter == index)
                {
                    char value = current.value;
                    return value;
                }
                current = current.next;
                counter++;
            }
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
