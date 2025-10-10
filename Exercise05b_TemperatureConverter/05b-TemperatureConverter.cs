double ConvertTemperatures(double celsius)
{
    return celsius * 9 / 5 + 32;
}


double celsius = double.Parse(args.Length > 0 ? args[0] : "0", System.Globalization.CultureInfo.InvariantCulture);


double fahrenheit = ConvertTemperatures(celsius);


Console.WriteLine($"{fahrenheit:F2}°F");
