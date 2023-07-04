/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int ReadNumber(string message){
    Console.Write(message);
    string import = Console.ReadLine();
    int number = Convert.ToInt32(import);
    return number;
}

int[] InputArray(int length){
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber($"Введите {i + 1}-й элемент ");
    }
    return array;
}

string Print(int [] array){
    return string.Join(", ", array);
}

int GetPosNumber(int [] array){ 
    int posNumber =0; 
    foreach (int el in array)
    {
        posNumber += el > 0 ? 1:0;
    }
    return posNumber;
} 

int m = ReadNumber("Введите количество чисел в массиве => ");
Console.WriteLine($"M = {m}");
int[] array;
array = InputArray(m);
Console.WriteLine($"[{Print(array)}]");
int posNumb = GetPosNumber(array);
Console.WriteLine($"Количество положительных чисел в массиве => {posNumb}");