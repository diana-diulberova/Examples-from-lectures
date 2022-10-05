using System.Linq;
string text = "(1,2) (2,3) (4,5) (9,7)"//возьмите текст
              .Replace("(", "")
              .Replace(")", "")//замените скобки
              ;
Console.WriteLine(text);//выведи получившийся результат на экран

var data = text.Split(" ")//возьми текст и раздели пробелами
               .Select(item => item.Split(','))//разбей текст с учетом символа разделителя ","
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))//преобразуй первый элемент массива в координату x (число), тоже самое со второй
               .Where(e => e.x % 2 == 0)//проверяем пары координат на четность
               .Select(point => (point.x * 10, point.y))//умножаем первую координату на 10
               .ToArray();//превращаем все в массив

for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);//выводим массив на экран
}