try
{
    double n1;
    double n2;
    Console.WriteLine("ingrese el primer numero");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("ingrese el segundo numero");
    n2 = int.Parse(Console.ReadLine());

    double suma = n1 + n2;
    double Resta = n1 - n2;
    double multiplicacion = n1 * n2;
    //Negar divicion si n2 es 0
    if (n2 != 0)
    {
        double division = n1 / n2;
        Console.WriteLine("la suma es :" + suma);
        Console.WriteLine("la resta es :" + Resta);
        Console.WriteLine("la division es :" + division);
        Console.WriteLine("las multiplicacion es :" + multiplicacion);
    }
    else
    {
        Console.WriteLine("Error: No es posible dividir entre cero .");
    }


}
catch(DivideByZeroException a)
{
    Console.WriteLine(a.Message);
}