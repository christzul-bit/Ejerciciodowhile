//Programa do while 18
Random random = new Random();
int opcion;
do
{
    Console.WriteLine("Seleccion una opción \n" +
        "1)Mostrar saludo \n" +
        "2)Mostrar número aleatorio \n" +
        "0)Salir_");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola");
            break;
        case 2:
            Console.WriteLine(random.Next(1, 100));
            break;
        case 0: Console.WriteLine("Adios..."); break;
        default: Console.WriteLine("Opción invalida"); break;
    }
    Console.WriteLine("Presione cualquier tecla para continuar");
    Console.ReadLine();
    Console.Clear();
} while (opcion != 0);