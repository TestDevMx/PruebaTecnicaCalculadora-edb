using System.Numerics;

namespace PruebaTecnicaCalculadora;

public class CalculadoraPersonalizada
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Restar(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        /*
            Se decidió usar el método de "Repeat" para repetir el valor de "a" la cantidad de veces que se indica en el valor de "b".

            Por ejemplo: si a = 5 y b = 6, para llegar a la multiplicación el método "repeat" genera 6 veces el valor de 5 y los suma:
            5+5+5+5+5+5 = 30
        */

        return Enumerable.Repeat(element: a, count: b).Sum();
    }

    public decimal Dividir(int a, int b)
    {
        /*
            Para resolver la division sin usar el operador "/" se opto por ir creando paso a paso el resultado del residuo para
             determinar si aun se puede realizar la division, sin embargo esta implementación se puede mejorar con recursividad.
        */

        int cociente;
        int resto = a % b;
        cociente = Cociente(a, b);

        if (resto == 0)
        {
            return cociente;
        }

        // Agrega 0 para primer decimal
        int parteEntera = cociente;
        int nuevoDividendo = Int32.Parse(resto.ToString() + '0');
        resto = nuevoDividendo % b;
        int parteDecimal1 = Cociente(nuevoDividendo, b);
        if (resto == 0)
        {
            return decimal.Parse($"{parteEntera}.{parteDecimal1}");
        }

        // Agrega 0 para segundo decimal
        nuevoDividendo = Int32.Parse(resto.ToString() + '0');
        resto = nuevoDividendo % b;
        int parteDecimal2 = Cociente(nuevoDividendo, b);
        if (resto == 0)
        {
            return decimal.Parse($"{parteEntera}.{parteDecimal1}{parteDecimal2}");
        }

        // Agrega 0 para tercer decimal
        int parteDecimal3 = Cociente(Int32.Parse(resto.ToString() + '0'), b);

        return Math.Round(decimal.Parse($"{parteEntera}.{parteDecimal1}{parteDecimal2}{parteDecimal3}"), 2);
    }

    private static int Cociente(int dividendo, int divisor)
    {
        int tmpCociente = 1;
        while ((tmpCociente * divisor) <= dividendo)
        {
            tmpCociente++;
        }

        return --tmpCociente;

    }
}
