using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    internal interface IDoubleLinkedList : IBaseLinkedList
    {
        void AddNodeFirst(int value);
        void AddNodeLast(int value);

        void DeleteNodeFirst();
        void DeleteNodeLast();
    }
}
