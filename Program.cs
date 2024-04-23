using System;
using System.Globalization;

class Program
{
    static void Main(string[] args) {
        const char ConwertRuToUsd = '1';
        const char ConwertUsdToRu = '2';
        const char ConwertEuroToUsd = '3';
        const char ConwertUsdToEuro = '4';
        const char ConwertRuToEuro = '5';
        const char ConwertEuroToRu = '6';
        const char Exit = 'S';
        float ballanseRu = 1000.0f;
        float ballanseUsd = 1000.0f;
        float ballanseEuro = 1000.0f;
        float courseRuToUsd = 100.0f;
        float courseUsdToRu = 0.01f;
        float courseEuroToUsd = 0.5f;
        float courseUsdToEuro = 2.0f;
        float courseRuToEuro = 200.0f;
        float courseEuroToRu = 0.005f;
        char directionConvert;
        float summa;
        bool isWork = true;

        while (isWork)
        {
            Console.WriteLine($"Направление конвертации: {ConwertRuToUsd}- Ru>>Usd; {ConwertUsdToRu}- Usd>>Ru");
            Console.WriteLine($"Направление конвертации: {ConwertEuroToUsd}- Euro>>Usd; {ConwertUsdToEuro}- Usd>>Euro");
            Console.WriteLine($"Направление конвертации: {ConwertRuToEuro}- Ru>>Euro; {ConwertEuroToRu}- Euro>>Ru");
            Console.WriteLine($"Продолжить конвертацию: любой символ; {Exit} - остановить ");
            Console.WriteLine();
            Console.WriteLine($"Баланс до конвертации: Ru {ballanseRu}, Usd {ballanseUsd}, Euro {ballanseEuro}");
            Console.Write("Выберите действие: ");
            directionConvert = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            Console.Write("Выберите сумму конвертации: ");
            summa = Convert.ToSingle(Console.ReadLine());

            switch (directionConvert)
            {
                case Exit:
                    isWork = false;
                    break;

                case ConwertRuToUsd:
                    if (summa > ballanseRu)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    ballanseRu -= summa;
                    ballanseUsd += summa / courseRuToUsd;
                    break;

                case ConwertUsdToRu:
                    if (summa > ballanseUsd)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    ballanseUsd -= summa;
                    ballanseRu += summa / courseUsdToRu;
                    break;

                case ConwertEuroToUsd:
                    if (summa > ballanseEuro)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    ballanseEuro -= summa;
                    ballanseUsd += summa / courseEuroToUsd;
                    break;

                case ConwertUsdToEuro:
                    if (summa > ballanseUsd)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    ballanseUsd -= summa;
                    ballanseEuro += summa / courseUsdToEuro;
                    break;

                case ConwertRuToEuro:
                    if (summa > ballanseRu)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    ballanseRu -= summa;
                    ballanseEuro += summa / courseRuToEuro;
                    break;

                case ConwertEuroToRu:
                    if (summa > ballanseEuro)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    ballanseEuro -= summa;
                    ballanseRu += summa / courseEuroToRu;
                    break;
            }

            Console.WriteLine($"Баланс после конвертации: Ru {ballanseRu}, Usd {ballanseUsd}, Euro {ballanseEuro}");
            Console.WriteLine("Продолжим конвертацию?");
            Console.WriteLine();
        }
    }
}
