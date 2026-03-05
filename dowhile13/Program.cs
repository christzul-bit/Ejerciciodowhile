//Programa do while 13
int contador = 0;
int num;
do
{
    Console.WriteLine("Ingrese un número entero, 0 termina el programa_");
    num = int.Parse(Console.ReadLine());
    contador++;
} while (num != 0);
Console.WriteLine($"La cantidad de números ingresados es {contador}");