// Создаем программу для нахождения веса самой тяжелой гири как пример 7 из первой лекции.
int a = 2;
int b = 4;
int c = 6;
int d = 8;
int e = 5;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);