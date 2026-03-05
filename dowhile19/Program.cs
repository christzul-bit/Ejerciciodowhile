//Programa do while 19
Console.WriteLine("Ingrese un número_");
int num = int.Parse(Console.ReadLine());
int contador = 1;
do
{
    Console.WriteLine($"{num} x {contador} = {num * contador}");
    contador++;
} while (contador <= 10);