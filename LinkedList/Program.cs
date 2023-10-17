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
                "one",
                "two",
                "three",
                "four"
            };

            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // удаляем элемент
            linkedList.Remove("two");
            Console.WriteLine("\nПосле удаления two");
            foreach (var item in linkedList) Console.WriteLine(item);

            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("three");
            Console.WriteLine(isPresent ? "three присутствует" : "three отсутствует");

            // добавляем элемент в начало            
            linkedList.AppendFirst("five");
            Console.WriteLine("\nПосле добавления five");
            foreach (var item in linkedList) Console.WriteLine(item);
        }
    }
}
