//Programa do while 12
int suma = 0;
int num;
do
{
    Console.WriteLine("Ingrese un número entero, 0 termina el programa_");
    num = int.Parse(Console.ReadLine());
    suma += num;
} while (num != 0);
Console.WriteLine($"La suma total es {suma}");