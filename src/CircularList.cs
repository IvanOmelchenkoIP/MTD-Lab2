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
            while (true)
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
            if (index > length || index < 0) throw new Exception("ERROR! Requesting to insert element by incorrect index!");

            if (index == length) 
            {
                Append(element);
                return;
            }

            int counter = 0;
            CharNode current = head;
            while (true)
            {
                if (counter == index) 
                {
                    CharNode next = current.next;

                    CharNode inserted = new CharNode();
                    inserted.value = element;
                    inserted.next = next;

                    current.next = inserted;

                    length++;
                    return;
                }
                current = current.next;
                counter++;
            }
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
            if (head == null) throw new Exception("ERROR! The Linked List is empty!");
            if (index >= length || index < 0) throw new Exception("ERROR! Element by incorrect index is requested!");

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
            int index = -1;
            int counter = 0;
            CharNode current = head;
            while (current.next != head)
            {
                if (current.value == element)
                {
                    index = counter;
                    break;
                }
                current = current.next;
                counter++;
            }
            return index;
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
