int cantIteraciones = 5;

string[] strings;
strings = new string[cantIteraciones];

for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine("Ingrese la " + (i + 1) + "º posicion del array: ");
    strings[i] = Console.ReadLine();
    Console.WriteLine();
}

Console.Clear();

for (int i = cantIteraciones - 1; i >= 0; i--)
{
    Console.WriteLine("Posicion " + (i + 1) + " del array: " + strings[i]);
}