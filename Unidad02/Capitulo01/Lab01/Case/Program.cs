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
    switch (decision.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine(inputTexto.ToUpper());
            break;

        case ConsoleKey.D2:
            Console.WriteLine(inputTexto.ToLower());
            break;
        case ConsoleKey.D3:
            Console.WriteLine(inputTexto.Length);
            break;
        default:
            Console.WriteLine("Opcion Incorrecta! Saliendo de la aplicacion.");
            break;

    }
}
else
{
    Console.WriteLine("La variable 'inputTexto' no tiene un texto asignado. Saliendo de la aplicacion.");
}