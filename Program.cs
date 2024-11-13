using System;
namespace лаба2_23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите сумму в рублях:");
                uint rubles = uint.Parse(Console.ReadLine());
                Console.WriteLine("Введите сумму в копейках:");
                byte kopeks = byte.Parse(Console.ReadLine());

                Money money = new Money(rubles, kopeks);
                Console.WriteLine("Создан объект Money: " + money.ToString());

                Console.WriteLine("Введите количество копеек для добавления:");
                uint additionalKopeks = uint.Parse(Console.ReadLine());

                Money newMoney = money.AddKopeks(additionalKopeks);
                Console.WriteLine("Новая сумма: " + newMoney.ToString());

                // Тестирование операций ++ и --
                Console.WriteLine("Тест операции ++: " + (++newMoney).ToString());

                Console.WriteLine("Тест операции --: " + (--newMoney).ToString());

                // Тестирование операции приведения типа uint
                uint moneyAsUint = (uint)newMoney;
                Console.WriteLine("Тест операции приведения к uint: " + moneyAsUint);

                // Тестирование операции приведения типа double
                double moneyAsDouble = newMoney;
                Console.WriteLine("Тест операции приведения к double: " + moneyAsDouble);

                // Тестирование операции сложения (Money + uint)
                Console.WriteLine("Введите число для сложения:");
                uint value = uint.Parse(Console.ReadLine());
                Money sum = newMoney + value;
                Console.WriteLine("Сумма: " + sum.ToString());

                // Тестирование операции сложения (uint + Money)
                Money sum2 = value + newMoney;
                Console.WriteLine("Сумма: " + sum2.ToString());

                // Тестирование операции вычитания (Money - uint)
                Console.WriteLine("Введите число для вычитания:");
                uint subtrahend = uint.Parse(Console.ReadLine());
                Money diff = newMoney - subtrahend;
                Console.WriteLine("Разность: " + diff.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат ввода!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }

}
