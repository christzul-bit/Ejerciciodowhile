//Programa do while 20
int num;
int suma = 0;
int cantidad = -1;
do
{
    Console.WriteLine("Ingrese un número, 0 termina el programa_");
    num = int.Parse(Console.ReadLine());
    suma += num;
    cantidad++;
} while (num != 0);
Console.WriteLine($"La suma total es {suma} \n" +
    $"se ingresaron {cantidad} números \n" +
    $"el promedio es {suma / cantidad}");
