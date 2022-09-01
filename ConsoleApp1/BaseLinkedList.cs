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
    public class BaseLinkedList : IBaseLinkedList
    {
        public Node head;
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
