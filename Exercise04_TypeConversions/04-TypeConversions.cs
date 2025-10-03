
double DemoImplicitConversions(int valorEntero)
{
    double resultado = valorEntero; 
    return resultado;
}

int DemoExplicitConversions(decimal valorDecimal)
{
    int resultado = (int)valorDecimal; 
    return resultado;
}


decimal originalValue = decimal.Parse(args.Length > 0 ? args[0] : "23.89");
int targetInt = int.Parse(args.Length > 1 ? args[1] : "17");


Console.WriteLine($"Conversión explícita a int: {DemoExplicitConversions(originalValue)}");
Console.WriteLine($"Conversión implícita a double: {DemoImplicitConversions(targetInt):0.0}");
