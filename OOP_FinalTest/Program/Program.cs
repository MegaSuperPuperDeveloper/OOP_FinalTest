// Создать проект калькулятора комплексных чисел (достаточно сделать сложение, умножение и деление).
// Применить при создании программы архитектурные паттерны, добавить логирование калькулятора.
// Соблюдать принципы SOLID, паттерны проектирования.

using OOP_FinalTest;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        iCalculator decorator = new Decorator(calculator, new Logger());
        ViewCalculator view = new ViewCalculator(decorator);
        view.run();
    }
}