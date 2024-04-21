using System;

class Program
{
    static void Main(string[] args) {
        float ballanseRu = 1000.0f;
        float ballanseUsd = 1000.0f;
        float ballanseEuro = 1000.0f;
        float courseRuToUsd = 100.0f;
        float courseUsdToRu = 0.01f;
        float courseEuroToUsd = 0.5f;
        float courseUsdToEuro = 2.0f;
        float courseRuToEuro = 200.0f;
        float courseEuroToRu = 0.005f;
        int directionConvert;
        float summa;
        float newMony;
        bool isWork = true;

        while (isWork)
        {
            Console.WriteLine("Направление конвертации: 1- Ru>>Usd; 2- Usd>>Ru");
            Console.WriteLine("Направление конвертации: 3- Euro>>Usd; 4- Usd>>Euro");
            Console.WriteLine("Направление конвертации: 5- Ru>>Euro; 6- Euro>>Ru");
            Console.WriteLine();
            Console.WriteLine($"Баланс до конвертации: Ru {ballanseRu}, Usd {ballanseUsd}, Euro {ballanseEuro}");
            Console.Write("Выберите направление конвертации: ");
            directionConvert = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите сумму конвертации: ");
            summa = Convert.ToSingle(Console.ReadLine());

            switch (directionConvert)
            {
                case 1://Ru>>Usd

                    if (summa > ballanseRu)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    newMony = summa / courseRuToUsd;
                    ballanseRu -= summa;
                    ballanseUsd += newMony;
                    break;
                case 2://Usd>>Ru

                    if (summa > ballanseUsd)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    newMony = summa / courseUsdToRu;
                    ballanseUsd -= summa;
                    ballanseRu += newMony;
                    break;
                case 3://Euro>>Usd

                    if (summa > ballanseEuro)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    newMony = summa / courseEuroToUsd;
                    ballanseEuro -= summa;
                    ballanseUsd += newMony;
                    break;
                case 4://Usd>>Euro

                    if (summa > ballanseUsd)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    newMony = summa / courseUsdToEuro;
                    ballanseUsd -= summa;
                    ballanseEuro += newMony;
                    break;
                case 5://Ru>>Euro

                    if (summa > ballanseRu)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    newMony = summa / courseRuToEuro;
                    ballanseRu -= summa;
                    ballanseEuro += newMony;
                    break;
                case 6://Euro>>Ru

                    if (summa > ballanseEuro)
                    {
                        Console.WriteLine("Недостаточно средств");
                        break;
                    }

                    newMony = summa / courseEuroToRu;
                    ballanseEuro -= summa;
                    ballanseRu += newMony;
                    break;
            }

            Console.WriteLine($"Баланс после конвертации: Ru {ballanseRu}, Usd {ballanseUsd}, Euro {ballanseEuro}");
            Console.WriteLine("Продолжим конвертацию?");
            Console.Write("Продолжить - любой символ, остановить - s: ");

            if (Convert.ToChar(Console.ReadLine()) == 's')
                isWork = false;

            Console.WriteLine();
        }
    }
}
