int [] array = {1, 22, 43, 5, 94, 43, 32, 45, 2};

int n = array.Length;
int find = 43;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // останавливает цикл на первом найденном варианте (если в массиве несколько одинаковых значений)
    }
    index++; // index = index + 1
    }
