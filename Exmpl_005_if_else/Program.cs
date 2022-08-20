Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "наташа") //ToLower - перевод символов строки с именем в нижний регистр.
{
    Console.WriteLine("Ура это же Наташа!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}