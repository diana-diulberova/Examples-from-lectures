// Создаем программу приветствия для пользователя-любимчика как пример 6 из первой лекции.
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine("username");
}