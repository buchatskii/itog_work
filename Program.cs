// Задание. 
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых
// меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма.

Console.Clear();
string[] stringArray = new string[3] { "1234", "1567", "-2"};
string[] newArray = new string[stringArray.Length];
int counter = 0;
int size = 3;
for (int a = 0; a < stringArray.Length; a++)
{
    if (stringArray[a].Length <= size)
    {
        newArray[counter] = stringArray[a];  
        counter++;   
    }
}
Console.Write($"[{String.Join(" ", stringArray)}] -> ");
Console.Write($"[{String.Join(" ", newArray)}]");
