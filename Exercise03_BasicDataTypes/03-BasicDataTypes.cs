using System;
using System.Runtime.InteropServices; 

void DemoBasicDataTypes()
{
    
    int numero = 10;
    float flotante = 3.14f;
    double doble = 2.71828;
    char caracter = 'C';
    bool booleano = true;
    string texto = "Hola, C#";

    Console.WriteLine("Valores de variables básicas:");
    Console.WriteLine($"int: {numero}");
    Console.WriteLine($"float: {flotante}");
    Console.WriteLine($"double: {doble}");
    Console.WriteLine($"char: {caracter}");
    Console.WriteLine($"bool: {booleano}");
    Console.WriteLine($"string: {texto}");
}

void ShowDataTypeSizes()
{
    
    Console.WriteLine("\nTamaños de tipos básicos:");
    Console.WriteLine($"int: {Marshal.SizeOf<int>()} bytes");
    Console.WriteLine($"float: {Marshal.SizeOf<float>()} bytes");
    Console.WriteLine($"double: {Marshal.SizeOf<double>()} bytes");
    Console.WriteLine($"char: {Marshal.SizeOf<char>()} bytes");
    Console.WriteLine($"bool: {Marshal.SizeOf<bool>()} bytes");
    Console.WriteLine($"string (referencia): {IntPtr.Size} bytes"); 
}


DemoBasicDataTypes();
ShowDataTypeSizes();
