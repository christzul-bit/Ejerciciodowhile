//Programa do while 17
int num;
int pares = 0;
do
{
    Console.WriteLine("Ingrese un número, 0 termina el programa_");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        pares++;
    }
} while (num != 0);
Console.WriteLine($"La cantidad de números pares es {pares}");