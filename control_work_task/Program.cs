// Задача. 
// Написать программу, которая: 
// Из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ```
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// ```

Console.Clear();

string [] stringArray1 = new string[5] {"Dog", "Table","Potato","Gitar","Blue"};
string [] stringArray2 = new string [stringArray1.Length - 3];

void Third (string [] stringArray1, string [] stringArray2)
{ 
    int count = 0;
    for (int i = 0; i < stringArray1.Length; i++)
    {
        if(stringArray1[i].Length <= 4)
        {
            stringArray2[count] = stringArray1[i];
            count++;
        }
    }
}


void PrintArray (string [] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
    if (length -i > 1) 
        Console.Write($"{array [i]}, ");
    else 
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");

}
Third(stringArray1, stringArray2);
PrintArray(stringArray1);
PrintArray(stringArray2);