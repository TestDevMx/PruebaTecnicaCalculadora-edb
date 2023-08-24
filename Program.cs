// See https://aka.ms/new-console-template for more information

// Aquí puedes realizar pruebas con la calculadora personalizada.

using PruebaTecnicaCalculadora;

var calc = new CalculadoraPersonalizada();
var resultadoSuma = calc.Sumar(5, 3);
var resultadoResta = calc.Restar(10, 4);
var resultadoMultiplicacion = calc.Multiplicar(6, 5);
var resultadoDivision = calc.Dividir(20, 4);

Console.WriteLine($"Suma: {resultadoSuma}");
Console.WriteLine($"Resta: {resultadoResta}");
Console.WriteLine($"Multiplicación: {resultadoMultiplicacion}");
Console.WriteLine($"División: {resultadoDivision}");
