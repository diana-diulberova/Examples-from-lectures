// Создаем массив, заполняем его случайными числами, ищем индекс числа 4.
void FillArray(int[] collection) // void - это метод, который не возвращает значения
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
{
    collection [index] = new Random().Next(1, 10);
    index++;
}
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Начинаем с -1, чтобы если ищется не 4, а, например, 444, то есть такого элемента нет - будет показываться -1

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; // Создай новый массив, в котором будет 10 элементов

FillArray(array); // Вызови новый массив
PrintArray(array); // Напечатай новый массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);