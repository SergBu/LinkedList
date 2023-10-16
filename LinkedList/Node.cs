using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //класс узла обобщённый, т.е. хранит данные любого типа
    public class Node<T>
    {
        public Node(T data)           
        {
            Data = data;
        }

        public T Data;

        public Node<T>? Next;
    }
}
