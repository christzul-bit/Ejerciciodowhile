//Programa do while 16
string password;
do
{
    Console.WriteLine("Ingrese su contraseña_");
    password = Console.ReadLine();
    if (password != "abc123")
    {
        Console.WriteLine("Contraseña incorrecta");
    }
} while (password != "abc123");
Console.WriteLine("Acceso consedido");