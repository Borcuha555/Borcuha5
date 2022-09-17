Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "василиса")
{
    Console.WriteLine("Я Тебя Люблю!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}
