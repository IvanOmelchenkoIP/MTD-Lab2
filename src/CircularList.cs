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
                head = new CharNode();
                head.value = element;
                head.next = head;
            }
            else
            {
                CharNode current = head;
                while (current.next != head) current = current.next;
                
                CharNode tail = new CharNode();
                tail.value = element;
                tail.next = head;

                current.next = tail;
            }
            length++;
        }

        public void Insert(char element, int index)
        { 
            if (index > length || index < 0) throw new IndexOutOfRangeException("ERROR! Requested to insert an element by incorrect index!");

            if (index == length)
            {
                Append(element);
                return;
            }

            CharNode current = head;
            if (index == 0)
            {
                CharNode inserted = new CharNode();

                inserted.value = element;
                inserted.next = head;

                while (current.next != head) current = current.next;
                current.next = inserted;

                head = inserted;
            }
            else
            {
                for (int counter = 0; counter < index - 1; counter++) current = current.next;
                CharNode next = current.next;

                CharNode inserted = new CharNode();
                inserted.value = element;
                inserted.next = next;

                current.next = inserted;
            }
            length++;
        }

        public char Delete(int index)
        {
            if (head == null) throw new NullReferenceException("ERROR! Requested to delete an element in empty Linked List!");
            if (index >= length || index < 0) throw new IndexOutOfRangeException("ERROR! Requested to delete an element by incorrect index!");

            char value;
            if (length == 1)
            {
                value = head.value;
                head = null;
                length = 0;
                return value;
            }

            CharNode current = head;
            if (index == 0)
            {
                value = current.value;
                while (current.next != head) current = current.next;

                head = head.next;
                current.next = head;

                length--;
                return value;
            }
            else
            {
                CharNode deleted = current.next;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                    deleted = current.next;
                }
                value = deleted.value;

                current.next = deleted.next;
                length--;
            }
            return value;
        }

        public void DeleteAll(char element)
        {
            if (head == null) return;

            while (true)
            {
                if (length == 1)
                {
                    if (head.value != element) return;
                    head = null;
                    length = 0;
                    return;
                }

                bool found = false;
                CharNode current = head;
                for (int counter = 0; counter < length; counter++)
                {
                    if (current.value == element)
                    {
                        Delete(counter);
                        found = true;
                        break;
                    }
                    current = current.next;
                }
                if (found == true) continue;
                return;
            }
        }

        public char Get(int index)
        {
            if (head == null) throw new NullReferenceException("ERROR! Requested to get an element in empty Linked List!");
            if (index >= length || index < 0) throw new IndexOutOfRangeException("ERROR! Requested to get an element by incorrect index!");

            CharNode current = head;
            for (int counter = 0; counter < index; counter++) current = current.next;

            char value = current.value;
            return value;
        }

        public CircularList Clone()
        {
            if (head == null) return new CircularList();

            CircularList cloned = new CircularList();
            CharNode current = head;
            while (true) 
            {
                cloned.Append(current.value);

                if (current.next == head) return cloned;
                current = current.next;
            }
        }

        public void Reverse()
        {
            if (head == null) return;

            CircularList reversed = new CircularList();
            int counter = length;
            while (counter > 0)
            {
                CharNode current = head;
                for (int i = 0; i < counter - 1; i++) current = current.next;
                reversed.Append(current.value);
                counter--;
            }
            head = reversed.head;
        }

        public int FindFirst(char element)
        {         
            int index = -1;
            CharNode current = head;
            for (int counter = 0; counter < length; counter++)
            {
                if (current.value == element)
                {
                    index = counter;
                    break;
                }
                current = current.next;
            }
            return index;
        }

        public int FindLast(char element)
        {
            int index = -1;
            CharNode current = head;
            for (int counter = 0; counter < length; counter++)
            {
                if (current.value == element) index = counter;
                current = current.next;
            }
            return index;
        }

        public void Clear()
        {
            head = null;
            length = 0;
        }

        public void Extend(CircularList list)
        {
            if (list.Length() == 0) return;

            CircularList extender = list.Clone();
            length += extender.Length();

            if (head == null)
            {
                head = extender.head;
                return;
            }

            CharNode current = head;
            while (current.next != head) current = current.next;
            current.next = extender.head;

            CharNode extCurrent = extender.head;
            while (extCurrent.next != extender.head) extCurrent = extCurrent.next;
            extCurrent.next = head;
        }
    }
}
