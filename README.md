# Methodologies and Technologies of Program Development - Laboratory work 2

## General Description

The program is an implementation of a Linked List that works with the values of type **char** with the following methods:

    int Length()

*Returns the length of a Linked List.* **If the list is empty, returns 0.**

    void Append(char element)

*Adds an element to the end of a Linked List.*

    void Insert(char element, int index)

*Adds an element to a Linked List by given index.* **If incorrect index is given, generates an exception.**

    char Delete(int index)

*Deletes an element from a Linked List by the index and returns its value.* **If incorrect index is given, generates an exception.**

    void DeleteAll(char element)

*Deletes all elements of the given value from a Linked List.* **If there is no element of a given value in the Linked List, applies no changes.**

    char Get(int index)

*Returns the value of the element from a Linked List by given index.* **If incorrect index is given, generates an exception.**

    LinkedListType Clone()

*Returns a copy of a cloned Linked List.*

    void Reverse()

*Reverses order of the elements in a Linked List.*

    int FindFirst(char element)

*Returns an index of the first instance of an element in a Linked List.* **If there is no element of a given value, returns -1.**

    int FindLast(char element)

*Returns an index of the last instance of an element in a Linked List.* **If there is no element of a given value, returns -1.**

    void Clear()

*Deletes all elements from a Linked List.*

    void Extend(LinkedListType list)

*Extends a LinkedList with another one.*

## Variant Calculation and Description

Variant is defined by the remainder of division of Gradebook number by 2.

Gradebook number = 0418.

0418 % 2 = 0.

Final task: implement Singly Linked Circular List

## Test Running

To run the unit test use the following command:

    dotnet test yourPathToUnitTestProject

For example:

    dotnet test UnitTests\UnitTests.csproj

## Failed CI Commit

