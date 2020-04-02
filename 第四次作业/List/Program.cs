using System;

namespace List
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            var n = head;
            while(n != null) 
            {
                action(n.Data);
                n = n.Next;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List.GenericList<int> testList = new GenericList<int>();
            for(int i = 0; i < 10; i++) {
                testList.Add(i);
            }
            int min = int.MaxValue; int max = int.MinValue;
            int sum = 0;
            testList.ForEach(x => sum += x);
            testList.ForEach(x => {if(x < min) min = x;});
            testList.ForEach(x => {if(x > max) max = x;});

            Console.WriteLine("{0} {1} {2}",sum, min, max);
        }
    }
}
