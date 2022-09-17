// Метод вида 1 
// Первая группа методов — не принимает никаких аргументов и ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1(); // вызов метода1

// Метод вида 2
// Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("msg: Текст сообщения"); // вызов метода2


// Метод вида 2.1
void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    }
// Method21(msg: "Text", count: 4); // вызов метода2.1
// Method21(count: 4, msg: "New text");



// Метод вида 3
/* 
Третья группа методов — может что-то возвращать, но не принимает никаких
аргументов. Например, может служить для генерации случайных данных.
*/
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); // вызов метода3
// Console.WriteLine(year);


// Метод вида 4
/*Четвёртая группа методов — что-то принимает (аргументы, данные). И что-то
возвращает для дальнейшей работы.
*/
/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result=result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "ret");
*/
// Console.WriteLine(res);


// Смотрим цикл for со счетчиком
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    for (int = 0; i < count; i++)
    {
        result=result + text;
    }
    return result;
}
string res = Method4(10, "ret");
*/
// Console.WriteLine(res);



// Цикл в цикле. Пример - программа для таблицы умножения
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/



//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
//             012345
// s[3] // r

/*
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine(); // Вывод пустой строки

newText = Replace(newText, 'к', 'K');
Console.WriteLine(newText);

Console.WriteLine(); // Вывод пустой строки

newText = Replace(newText, 'В', 'в');
Console.WriteLine(newText);
*/



// Упорядочивание массива от меньшего к большему
/*
int[] arr = {1, 5, 3, 6, 9, 2, 4, 1, 8};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for(int j = i+1; j<array.Length; j++)
    {
       if(array[j] < array [minPosition]) minPosition = j;
    } 

    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/



// Упорядочивание массива от большего к меньшему

int[] arr = {1, 5, 3, 6, 9, 2, 4, 1, 8};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;

        for(int j = i+1; j<array.Length; j++)
    {
       if(array[j] > array [maxPosition]) maxPosition = j;
    } 

    int temporary = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);