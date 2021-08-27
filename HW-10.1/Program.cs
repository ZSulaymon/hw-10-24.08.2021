using System;

namespace HW_10._1
{
    public class CurrencyConverter
    {
        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }
        public CurrencyConverter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ConvertToUsd(double value)
        {
            return value / USD;
        }

        public double ConvertToEur(double value)
        {
            return value / EUR;
        }

        public double ConvertToRub(double value)
        {
            return value / RUB;
        }

        public double ConvertFromUsd(double value)
        {
            return USD * value;
        }

        public double ConvertFromEur(double value)
        {
            return EUR * value;
        }

        public double ConvertFromRub(double value)
        {
            return RUB * value;
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var converter = new CurrencyConverter(11.34, 13.50, 0.1560);

            Console.WriteLine("Выберите вариант:");
            Console.WriteLine("1: Конвертация в сомони");
            Console.WriteLine("2: Конвертация из сомони");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertTo(converter);
                    break;
                case 2:
                    ConvertFrom(converter);
                    break;
            }

            Console.WriteLine("Готово");
            Console.ReadKey();
        }

        private static void ConvertTo(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Выберите вариант:");
            Console.WriteLine("1: Конвертация из USD");
            Console.WriteLine("2: Конвертация из EUR");
            Console.WriteLine("3: Конвертация из RUB");

            var option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Ввидите сумму в долларах");

            }
            else if (option == 2)
            {
                Console.WriteLine("Ввидите сумму в евро");
            }
            else
            {
                Console.WriteLine("Ввидите сумму в рубль");
            }
            Console.WriteLine("Ввидите сумму");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertFromUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertFromEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertFromRub(input));
                    break;
            }
        }

        private static void ConvertFrom(CurrencyConverter currencyConverter)
        {
            Console.WriteLine("Выберите вариант:");
            Console.WriteLine("1: Конвертация в USD");
            Console.WriteLine("2: Конвертация В EUR");
            Console.WriteLine("3: Конвертация в RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Сумму  в сомони");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(currencyConverter.ConvertToUsd(input));
                    break;
                case 2:
                    Console.WriteLine(currencyConverter.ConvertToEur(input));
                    break;
                case 3:
                    Console.WriteLine(currencyConverter.ConvertToRub(input));
                    break;
            }
        }
    }
}
