//Programa do while 9
int num = 0;
do
{
    num++;
    Console.Write(num);
    if (num % 2 == 0)
    {
        Console.WriteLine("Es par");
    } else
    {
        Console.WriteLine(" Es impar");
    }
} while (num < 20);