//Собрать строку с числами от a до b

/*string NumbersRec(int a, int b)
{
    if(a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{b} ";
}
Console.WriteLine(NumbersRec(1, 10));*/

//от большего к меньшему
/*string NumbersRec(int a, int b)
{
    if(a < b) return NumbersRec(a + 1, b) + $"{a} ";
    else return $"{b} ";
}
Console.WriteLine(NumbersRec(1, 10));*/

//сумма чисел от 1 до n
/*int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n-1);
}
Console.WriteLine(SumRec(10));*/

//факториал
/*int FactorialRec(int n)
{
    if(n == 1 || n == 0) return 1;
    else return n * FactorialRec(n-1);
}
Console.WriteLine(FactorialRec(10));*/

//число в степени
/*int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n-1) * a;
}
Console.WriteLine(PowerRec(2, 10));*/

//применяем сокращающие формулы
/*int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 10));*/

//сборка всех возможных слов из алфавита с указанным количеством символов
/*int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if(length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for(int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[2]);*/

//работа с директориями
//string path = "D:/Домашнее задание GeekBrains/Examples/Example002_HelloUser";
/*DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for(int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}*/

/*void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for(int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for(int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");   
    }
}
string path = "D:/Домашнее задание GeekBrains/Examples/Example002_HelloUser";
CatalogInfo(path);
*/

//игра с блинчиками
/*void Towers(string with =  "1", string on = "3", string some = "2", int count = 4)
{
    if(count > 1) Towers(with, some, on, count -1);
    Console.WriteLine($"{with} >> {on}");
    if(count > 1) Towers(some, on, with, count - 1);
}
Towers();*/

//обход разных структур
/*string emp = String.Empty;
string[] tree = {emp, "/", "+", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                0    1    2     3    4    5    6    7    8    9    10   11    
void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if(right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();*/

//Опять Фибоначчи
/*decimal fRec = 0;
decimal fIte = 0;
decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n -2);
}
decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for(int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}
Console.ReadLine();
DateTime dt = DateTime.Now;
for(int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for(int n = 10; n < 40; n++)
{
     Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
     fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.ReadLine();*/

int[,] pic = new int[1000,1000];
for(int i = 0; i < 1000; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 999] = 1;
    pic[999, i] = 1;
}

//PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
//PrintImage(pic);

void PrintImage(int[,] image)
{
  for(int i = 0; i < image.GetLength(0); i++)
  {
    for(int j = 0; j < image.GetLength(1); j++)
    {
        //Console.Write($"{image[i, j]} ");
        if(image[i, j] == 0) Console.Write($" ");
        else Console.Write($"+");
    }
    Console.WriteLine();
  }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}