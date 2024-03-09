using System.Numerics;

namespace OOP_FinalTest;

public interface iCalculator
{
    Complex Addition(double num11, double num12, double num21, double num22);
    Complex Multiply(double num11, double num12, double num21, double num22);
    Complex Divide(double num11, double num12, double num21, double num22);
    Complex Substract(double num11, double num12, double num21, double num22);
}