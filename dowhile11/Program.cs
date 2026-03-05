//Programa do while 11
int contador = 0;
int suma = 0;
do
{
    Console.WriteLine("Ingrese un número_");
    int num = int.Parse(Console.ReadLine());
    suma += num;
    contador++;
} while (contador < 5);
Console.WriteLine($"La suma total es {suma}");
