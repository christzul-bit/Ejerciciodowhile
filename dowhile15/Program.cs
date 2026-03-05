//Programa do while 15
int num;
do
{
    Console.WriteLine("Ingrese un número positivo_");
    num = int.Parse(Console.ReadLine());
} while (num < 0);
Console.WriteLine("Bien, haz hecho caso");