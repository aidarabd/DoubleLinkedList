using System;
using System.Collections;
using ConsoleApp2.Interfaces;
namespace ConsoleApp2
{
    public class DoubleLinkedList : BaseLinkedList, IDoubleLinkedList
    {
        public DoubleLinkedList()
        {
            head = null;
        }

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

        //bubble
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
                        int tempVal = currentPointer.value;
                        currentPointer.value = currentPointer.next.value;
                        currentPointer.next.value = tempVal;
                        swapped = true;
                    }
                    currentPointer = currentPointer.next;
                }
                endPointer = currentPointer;
            }
            
        }

        public void AddNodeLast(int value)
        {
            throw new NotImplementedException();
        }

        public void DeleteNodeLast()
        {
            throw new NotImplementedException();
        }
    }
}
