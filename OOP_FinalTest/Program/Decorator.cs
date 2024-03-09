using System.Numerics;

namespace OOP_FinalTest;

public class Decorator : iCalculator
{

    private Calculator calc;
    private Logger log;

    public Decorator(Calculator calc, Logger log)
    {
        this.calc = calc;
        this.log = log;
    }

    public Complex Addition(double num11, double num12, double num21, double num22)
    {
        log.write($"Было совершенно сложение с аргументами: Первый аргумент - вещественное число: {num11}, мнимое: {num12}; " +
                  $"Второй аргумент - вещественное число: {num21}, мнимое: {num22}; ");
        log.write($"{calc.Addition(num11, num12, num21, num22)}. Первый аргумент - вещественное число; Второй аргумент - мнимое число");
        return calc.Addition(num11, num12, num21, num22);
    }

    public Complex Multiply(double num11, double num12, double num21, double num22)
    {
        log.write($"Было совершенно умножение с аргументами: Первый аргумент - вещественное число: {num11}, мнимое: {num12}; " +
                  $"Второй аргумент - вещественное число: {num21}, мнимое: {num22}; ");
        log.write($"{calc.Multiply(num11, num12, num21, num22)}. Первый аргумент - вещественное число; Второй аргумент - мнимое число");
        return calc.Multiply(num11, num12, num21, num22);
    }

    public Complex Divide(double num11, double num12, double num21, double num22)
    {
        log.write($"Было совершенно деление с аргументами: Первый аргумент - вещественное число: {num11}, мнимое: {num12}; " +
                  $"Второй аргумент - вещественное число: {num21}, мнимое: {num22}; ");
        log.write($"{calc.Divide(num11, num12, num21, num22)}. Первый аргумент - вещественное число; Второй аргумент - мнимое число");
        return calc.Divide(num11, num12, num21, num22);
    }

    public Complex Substract(double num11, double num12, double num21, double num22)
    {
        log.write($"Было совершенно вычитание с аргументами: Первый аргумент - вещественное число: {num11}, мнимое: {num12}; " +
                  $"Второй аргумент - вещественное число: {num21}, мнимое: {num22}; ");
        log.write($"{calc.Substract(num11, num12, num21, num22)}. Первый аргумент - вещественное число; Второй аргумент - мнимое число");
        return calc.Substract(num11, num12, num21, num22);
    }
}