
namespace algorithms
{

    class Helper
    {

        public void ReverseSinglyLinkedList()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            for (int i = 1; i < 10; i++)
                sll.Add(i);


            sll.PrintAll(sll.head);
            sll.Reverse(sll.head);
            sll.PrintAll(sll.head);
        }

        public void InsertionSort()
        {
            int[] A = { 7, 8, 9, 4, 3, 2, 1 };
            Sorting.InsertionSort(A);
            Sorting.PrintArray(A);
        }


    }
}