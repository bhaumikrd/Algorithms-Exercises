﻿using static System.Console;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            Queue myQueue = new Queue(5);
            myQueue.insert(100);
            myQueue.insert(200);
            myQueue.insert(300);
            myQueue.insert(400);
            myQueue.view();

            WriteLine("Front of the queue is " + myQueue.peekFront());
            myQueue.remove();
            WriteLine("Front of the queue is " + myQueue.peekFront());
        }
    }

    public class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void insert(long j)
        {
            if (isFull())
            {
                WriteLine("QUeue is full");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                myQueue[rear] = j;
                items++;
            }
        }

        public long remove()
        {
            long temp = myQueue[front];
            front++;

            if (front == maxSize)
            {
                front = 0;
            }

            return temp;
        }

        public long peekFront()
        {
            return myQueue[front];
        }

        public bool isEmpty()
        {
            return (items == 0);
        }
        public bool isFull()
        {
            return (items == maxSize);
        }

        public void view()
        {
            Write("[");
            for (int i = 0; i < myQueue.Length; i++)
            {
                Write(myQueue[i] + " ");
            }
            WriteLine("]");
        }
    }
}
