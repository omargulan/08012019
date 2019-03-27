using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08012019
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива кошелька и наполнения его банкнотами
            Money[] dengi = new Money[4];
            dengi[0] = new Money(50, 4);
            dengi[1] = new Money(100, 8);
            dengi[2] = new Money(500, 2);
            dengi[3] = new Money(1000, 3);

            // Вывести информацию о всех банкнотах
            dengi[0].ShowInfoMoney(dengi);

            // Вывести сумму всех банкнот
            Console.WriteLine("В вашем кошельке: {0} тг.", dengi[0].ShowAllMoney(dengi));

            // Хватит ли денег на покупку
            if (dengi[0].BuyOne(dengi, 3500))
                Console.WriteLine("На оплату товара, денежных стредств хватает");
            else
                Console.WriteLine("На оплату товара, денег НЕ хватает");

            // Купить на все деньги
            Console.WriteLine("На {0} можно купть {1} ед. товара по 330",
            dengi[0].ShowAllMoney(dengi), dengi[0].BuyAll(dengi, 330));

            // Свойства: чтение-запись номинала банкнот и колличества,
            // вывод суммы всех банкнот данного номинала
            Console.WriteLine("\nНоминал банкнот: {0}\n" +
            "Колличество банкнот: {1}\n" +
            "Сумма всех банкнот данного номинала: {2}",
           dengi[3].Banknote, dengi[3].Number, dengi[3].AllMoneyBanknote);
            dengi[3].Banknote = 5000;


            Console.WriteLine("\nНоминал банкнот: {0}\n" +
            "Колличество банкнот: {1}\n" +
            "Сумма всех банкнот данного номинала: {2}",
           dengi[3].Banknote, dengi[3].Number, dengi[3].AllMoneyBanknote);

            dengi[0]++;

            //вывод
            Money M = new Money(1, 1);
            string s = (string)M;
            Console.WriteLine(s);
            string s1 = "2 2";
            Money M1 = (Money)s1;




            Console.ReadKey();
        }
    }
}
