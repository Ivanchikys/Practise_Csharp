using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MyCircularBuffer<T>(int capacity)
    {
        public T[] buffer = new T[capacity];
        public int head = 0;
        public int tail = 0;
        public int count = 0;
        public int capacity = capacity;
        
        public void Add(T item)
        {
            buffer[tail] = item;
            tail = (tail + 1) % capacity;
            if (count == capacity)
            {
                head = (head + 1) % capacity;
            }
            else
            {
                count++;
            }
        }

        public T Remove()
        {
            if (count == 0)
                throw new InvalidOperationException("Буффер пустой");

            T item = buffer[head];
            head = (head + 1) % capacity;
            count--;
            return item;
        }

        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Буффер пустой");

            return buffer[head];
        }
        public bool IsEmpty() => count == 0;
        public bool IsFull() => count == capacity;
    }

}
