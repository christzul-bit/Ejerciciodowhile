//Programa do while 14
int mayor = 0;
int num;
do
{
    Console.WriteLine("Ingrese un numero, 0 termina el programa_");
    num = int.Parse(Console.ReadLine());
    if (mayor < num)
    {
        mayor = num;
    }
} while (num != 0);
Console.WriteLine($"El número mayor es {mayor}");