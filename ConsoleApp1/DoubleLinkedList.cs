using System;
using System.Collections;
using ConsoleApp2.Interfaces;
namespace ConsoleApp2
{
    public class DoubleLinkedList : BaseLinkedList, IDoubleLinkedList
    {
        //-------
        // auth Aidar Abakir
        //-------

        public DoubleLinkedList()
        {
            head = null;
        }

        //Add node as first element
        public void AddNodeFirst(int value)
        {
            Node node = new Node();
            node.value = value;
            node.next = null;
            node.previous = null;
            
            if(head == null)
            {
                head = node;
            }
            else
            {
                head.previous = node;
                node.next = head;
                head = node;
            }
        }

        //Delete first element
        public void DeleteNodeFirst()
        {
            if(head != null)
            {   
                if(head.next != null)
                {
                    head = head.next;
                    head.previous = null;
                }
                else
                {
                    head = null;
                }
            }
        }

        //bubble sort
        public void Sort() 
        {
            bool swapped = true;
            Node currentPointer;
            Node endPointer = null;

            if(head == null)
            {
                return;
            }

            while (swapped)
            {
                swapped = false;
                currentPointer = head;

                while(currentPointer.next != endPointer)
                {
                    if(currentPointer.value > currentPointer.next.value)
                    {
                        // here we swap
                        int tempVal = currentPointer.value;
                        currentPointer.value = currentPointer.next.value;
                        currentPointer.next.value = tempVal;
                        swapped = true;
                    }
                    currentPointer = currentPointer.next;
                }
                //move end node
                endPointer = currentPointer;
            }
            
        }

        //needs to be implemented
        public void AddNodeLast(int value)
        {
            throw new NotImplementedException();
        }

        //needs to be implemented
        public void DeleteNodeLast()
        {
            throw new NotImplementedException();
        }
    }
}
