// Задача. Написать программу, которая из имеющегося массива строк формирует
//массив из строк длина которых меньше либо равна 3 символа. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте выполнения 
//алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// заводим данные по массиву (массив с кухонными приборами) 
Console.Clear();
Console.WriteLine("задан строковый массив данных - кухонные приборы:");
Console.WriteLine("pot, fork, saucepan, turk, cup, skillet, teapot");
Console.WriteLine("находим элементы, в  которых количество элементов менее или равно 3-м символам");
string[] dishes = new string[] { "pot", "fork", "saucepan", "turk", "cup", "skillet", "teapot" };
void PrintArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
        Console.Write($"{array[i]}, ");
        }
    }
Console.Write("\b\b");
}
PrintArray(dishes);
//Console.WriteLine("блок-схема к решению задачи:");
//![block-scheme](controlwork.jpg);
