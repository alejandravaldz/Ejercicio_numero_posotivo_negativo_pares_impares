// See https://aka.ms/new-console-template for more information
Console.WriteLine("Determina si el numero es positvo, negativo cuanto son pares y cuantos son impares ");
Console.WriteLine();


Console.Write("Ingrese la cantidad de número: ");
int cantidadNumero = Convert.ToInt32(Console.ReadLine());

int positivos = 0;
int negativos = 0;
int pares = 0;
int impares = 0;

for (int i = 0; i < cantidadNumero; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        positivos++;
    }
    else if (numero < 0)
    {
        negativos++;
    }

    if (numero % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}

Console.WriteLine($"Cantidad de números positivos: {positivos}");
Console.WriteLine($"Cantidad de números negativos: {negativos}");
Console.WriteLine($"Cantidad de números pares: {pares}");
Console.WriteLine($"Cantidad de números impares: {impares}");
    }
}


