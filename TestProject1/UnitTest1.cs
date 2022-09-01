using ConsoleApp2;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNodeTest()
        {
            List<int> list = new List<int>();
            DoubleLinkedList doubleLinkedLst = new DoubleLinkedList();
            doubleLinkedLst.AddNodeFirst(5);
            doubleLinkedLst.AddNodeFirst(2);

            foreach(var node in doubleLinkedLst)
            {
                list.Add(node);
            }
            Assert.Contains(5, list);
            Assert.Contains(2, list);
        }

        [Test]
        public void DeleteNodeTest()
        {
            List<int> list = new List<int>();
            DoubleLinkedList doubleLinkedLst = new DoubleLinkedList();
            doubleLinkedLst.AddNodeFirst(5);
            doubleLinkedLst.AddNodeFirst(2);
            doubleLinkedLst.DeleteNodeFirst();
            foreach (var node in doubleLinkedLst)
            {
                list.Add(node);
            }
            Assert.That(list, Has.No.Member(2));
            Assert.That(list.Count, Is.EqualTo(1));
        }

        [Test]
        public void SortTest()
        {
            List<int> list = new List<int>();
            List<int> expectedList = new List<int>() {1,2,3,3,4,5};

            DoubleLinkedList doubleLinkedLst = new DoubleLinkedList();

            int[] arr = { 5, 4, 3, 3, 2, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                doubleLinkedLst.AddNodeFirst(arr[i]);
            }
            doubleLinkedLst.Sort();
            foreach(var nodeValue in doubleLinkedLst)
            {
                list.Add(nodeValue);
            }
            CollectionAssert.AreEqual(expectedList, list);
        }

    }
}