using ConsoleApp2;
Console.WriteLine("Hello World!");

DoubleLinkedList dll = new DoubleLinkedList();


int[] arr = { 5, 4, 3, 3, 2, 1 };
for (int i = 0; i < arr.Length; i++)
{
    dll.AddNodeFirst(arr[i]);
}
dll.DeleteNodeFirst();
dll.Sort();

foreach (var i in dll)
{
    Console.WriteLine(i);
}


//Node first = new Node();
//first.value = 10;
//first.next = null;
//first.previous = null;
//MyList.head = first;


//Node second = new Node();
//second.value = 20;
//second.next = null;

//second.previous = first;
//first.next = second;

//Node third = new Node();
//third.value = 30;
//third.next = null;

//third.previous = second;
//second.next = third;
