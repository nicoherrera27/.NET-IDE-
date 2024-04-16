string inputTexto;

Console.WriteLine("Ingrese un texto: ");

inputTexto = Console.ReadLine();

if (inputTexto != "")
{

    Console.WriteLine("Menu: ");
    Console.WriteLine("1- Mostrar texto en mayusculas.");
    Console.WriteLine("2- Mostrar texto en minusculas.");
    Console.WriteLine("3- Mostrar cantidad de caracteres en el texto.");

    ConsoleKeyInfo decision = Console.ReadKey();
    Console.WriteLine();

    if (decision.Key == ConsoleKey.D1)
    {
        Console.WriteLine(inputTexto.ToUpper());
    }
    else
    {
        if (decision.Key == ConsoleKey.D2)
        {
            Console.WriteLine(inputTexto.ToLower());
        }
        else
        {
            if (decision.Key == ConsoleKey.D3)
            {
                Console.WriteLine(inputTexto.Length);
            }
            else
            {
                Console.WriteLine("Opcion Incorrecta! Saliendo de la aplicacion.");
            }
        }
    }
}
else
{
    Console.WriteLine("La variable 'inputTexto' no tiene un texto asignado. Saliendo de la aplicacion.");
}