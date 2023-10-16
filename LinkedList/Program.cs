using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>
            {
                // добавление элементов
                "Tom",
                "Alice",
                "Bob",
                "Sam"
            };

            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // удаляем элемент
            linkedList.Remove("Alice");
            Console.WriteLine("\nПосле удаления Alice");
            foreach (var item in linkedList) Console.WriteLine(item);

            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent ? "Sam присутствует" : "Sam отсутствует");

            // добавляем элемент в начало            
            linkedList.AppendFirst("Bill");
            Console.WriteLine("\nПосле добавления Billa");
            foreach (var item in linkedList) Console.WriteLine(item);
        }
    }
}
