using System.Numerics;

namespace OOP_FinalTest;

public class Calculator : iCalculator
{
    public Complex Addition(double num11, double num12, double num21, double num22)
    {
        return Complex.Add(new Complex(num11, num12), new Complex(num22, num22));
    }

    public Complex Multiply(double num11, double num12, double num21, double num22)
    {
        return Complex.Multiply(new Complex(num11, num12), new Complex(num22, num22));
    }

    public Complex Divide(double num11, double num12, double num21, double num22)
    {
        return Complex.Divide(new Complex(num11, num12), new Complex(num22, num22));throw new NotImplementedException();
    }

    public Complex Substract(double num11, double num12, double num21, double num22)
    {
        return Complex.Subtract(new Complex(num11, num12), new Complex(num22, num22));throw new NotImplementedException();
    }
}