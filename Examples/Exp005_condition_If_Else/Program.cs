Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "Gazinur")
{
   Console.WriteLine("Ура, это же " + username +"!!!");
}
else
{
    Console.WriteLine("Привет, " + username);
}