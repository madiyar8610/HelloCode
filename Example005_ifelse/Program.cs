Console.Write("Login: ");
string username = Console.ReadLine();

if ( username.ToLower() == "masha" )
{
    Console.WriteLine("Ura, etoje MASHA !");
}
else
{
    Console.Write("Privet, ");
    Console.WriteLine(username);
}
