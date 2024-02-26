try
{
    Console.WriteLine("Este Programa calculara el número mayor de 3 que el usuario ingrese");
    Console.WriteLine("\nIngrese el primer número:");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número:");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el tercer número:");
    int num3 = int.Parse(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine("El número Mayor ingresado es: " + num1);
    }
    else if (num1 < num2 && num3 < num2)
    {
        Console.WriteLine("El número Mayor ingresado es: " + num2);
    }
    else
    {
        Console.WriteLine("El número Mayor ingresado es: " + num3);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Usted no Introdujo un Numero Valido");
}
