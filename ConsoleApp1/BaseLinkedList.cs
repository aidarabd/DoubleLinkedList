using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2
{
    //Base class for overall Linked list types (one way, two way)
    public class BaseLinkedList : IBaseLinkedList
    {
        public Node head;

        //Enumarator implementation
        public IEnumerator<int> GetEnumerator()
        {
            var current = this.head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
