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
            if (index > length || index < 0) throw new Exception("ERROR! Requesting to insert element by incorrect index!");

            if (index == length)
            {
                Append(element);
            }
            else
            {
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
        }

        public char Delete(int index)
        {
            if (head == null) throw new Exception("ERROR! Can`t delete any element of an empty Linked List!");
            if (index >= length || index < 0) throw new Exception("ERROR! Requested to delete an element by incorrect index!");

            if (head.next == head)
            {
                char value = head.value;
                head = null;

                length = 0;
                return value;
            }

            int counter = 0;
            CharNode current = head;
            CharNode deleted = current.next;
            while (true)
            {
                if (counter == index - 1)
                {
                    CharNode next = deleted.next;

                    char value = deleted.value;
                    current.next = next;

                    length--;
                    return value;
                }
                current = current.next;
                deleted = current.next;
                counter++;
            }
        }

        public void DeleteAll(char element)
        {
            if (head == null) return;

            CharNode current = head;
            CharNode previous = null;
            CharNode next = current.next;
            while (true)
            {
                if (current.value == element)
                {
                    if (current == head)
                    {
                        if (current.next == head)
                        {
                            head = null;
                            return;
                        }
                        else
                        {
                            CharNode tmp = head;
                            while (true)
                            {
                                if (tmp.next == head)
                                {
                                    tmp.next = next;
                                    break;
                                }
                                tmp = tmp.next;
                            }
                            head = next;
                        }
                        length--;
                    }
                    else
                    {
                        previous.next = next;
                    }
                }
                if (current.next == head) return;
                previous = current;
                current = current.next;
                next = current.next;
            }
        }

        public char Get(int index)
        {
            if (head == null) throw new Exception("ERROR! The Linked List is empty!");
            if (index >= length || index < 0) throw new Exception("ERROR! Element by incorrect index is requested!");

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
            CharNode current;
            CharNode next;
            while (true)
            {
                current = head;
                next = current.next;
                while (true)
                {
                    if (next.next == head)
                    {
                        if (current.next == head)
                        {
                            reversed.Append(current.value);
                            head = reversed.head;
                            return;
                        }
                        reversed.Append(next.value);
                        current.next = head;
                        break;
                    }
                    current = current.next;
                    next = current.next;
                }
            }
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
            int index = -1;
            int counter = 0;
            CharNode current = head;
            while (current.next != head)
            {
                if (current.value == element) index = counter;

                current = current.next;
                counter++;
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
            while (true)
            {
                if (current.next == head)
                {
                    current.next = extender.head;
                    break;
                }
                current = current.next;
            }

            CharNode extCurrent = extender.head;
            while(true)
            {
                if (extCurrent.next == extender.head) 
                {
                    extCurrent.next = head;
                    break;
                }
                extCurrent = extCurrent.next;
            }
        }
    }
}
