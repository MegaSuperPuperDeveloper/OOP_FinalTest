namespace OOP_FinalTest;

public class ViewCalculator
{
    private iCalculator calculator;

    public ViewCalculator(iCalculator calculator)
    {
        this.calculator = calculator;
    }

    public void run()
    {
        while (true)
        {
            Console.Write("Введите вещественное число первого числа: ");
            double num11 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимое число первого числа: ");
            double num12 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вещественное число второго числа: ");
            double num21 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимое число второго числа: ");
            double num22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Что делаем(Введите номер операции)? 1) Сложение 2) Вычитание 3) Деление 4) Умножение.");
            string ans = Console.ReadLine();
            if (ans == "1")
            {
                calculator.Addition(num11, num12, num21, num22);
            }
            else if (ans == "2")
            {
                calculator.Substract(num11, num12, num21, num22);
            }
            else if (ans == "3")
            {
                calculator.Divide(num11, num12, num21, num22);
            }
            else if (ans == "4")
            {
                calculator.Multiply(num11, num12, num21, num22);
            }
        }
    }
    
}
