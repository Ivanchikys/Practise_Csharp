using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CircularBufferManager<T>
    {
        private MyCircularBuffer<T> buffer;

        public CircularBufferManager(int capacity)
        {
            buffer = new MyCircularBuffer<T>(capacity);
        }

        public void AddItem(T item)
        {
            buffer.Add(item);
            Console.WriteLine($"Добавлен: {item}");
        }
        public void RemoveItem()
        {
            if (!buffer.IsEmpty())
            {
                T removedItem = buffer.Remove();
                Console.WriteLine($"Удалён: {removedItem}");
            }
            else
            {
                Console.WriteLine("Буффер пустой. Невозможно удалить несуществующий объект");
            }
        }
        public void PeekItem()
        {
            if (!buffer.IsEmpty())
            {
                Console.WriteLine($"Следующий объект: {buffer.Peek()}");
            }
            else
            {
                Console.WriteLine("Буффер пустой");
            }
        }
    }
}
