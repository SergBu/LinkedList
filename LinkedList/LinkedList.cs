using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //класс списка
    public class LinkedList<T> : IEnumerable<T>
    {
        Node<T>? head; //первый элемент
        Node<T>? tail; //последний элемент
        private int count; //кол-во


        //сложность метода O(1)
        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (head is null)
            {
                head = node;
                tail = head;
            }
            else
            {
                tail.Next = new Node<T>(data);
                tail = tail.Next;
            }

            count++;
        }

        public void Remove(T data)
        {
            var current = head;
            Node<T>? previous = default;

            while (current is not null)
            {
                if (current.Data.Equals(data))
                {
                    //если узел в середине или конце, теперь previous ссылается не на
                    //current, а на current.Next
                    if (previous is not null)
                    {
                        previous.Next = current.Next;
                        count--;
                    }
                    //если current.Next не установлен, значит узел последний - меняем tail
                    if (current.Next is null)
                    {
                        tail = previous;
                    }
                    //если удаляется первый элемен, то переустанавливаем значение head
                    if (current == head)
                    {
                        head = current.Next;
                        count--;
                    }
                    //если после удаления список пуст - сбрасываем tail
                    if (count is 0)
                    {
                        tail = null;
                    }
                }

                previous = current;
                current = current.Next;

            }
        }

        public void Clear()
        {
            head = default;
            tail = default;
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count is 0;
        }

        public void AppendFirst(T data)
        {
            var node = new Node<T>(data);

            if (head is null)
            {
                head = node;
                tail = head;
            }
            else
            {
                node.Next = head;
                head = node;
            }

            count++;
        }

        public bool Contains(T data)
        {
            var current = head;
            Node<T>? previous = default;

            while (current is not null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current is not null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
