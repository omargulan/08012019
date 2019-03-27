using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08012019
{
    class Money
    {
        private int nominal; // Номинал купюры
        private int count; // Колличество купюр

        public Money(int banknotes, int number)
        {
            nominal = banknotes;
            count = number;
        }
        public void ShowInfoMoney(Money[] purse)
        {
            // Цикл выводящий номинал и колличество купюр
            foreach (Money i in purse)
            {
                Console.WriteLine("Купюра номиналом: {0} T. - {1} шт.",
                i.nominal, i.count);
            }
        }
        public bool BuyOne(Money[] purse, int price) //Хватает ли денежных средств на покупку
        {
            return (ShowAllMoney(purse) >= price);
        }
        public int BuyAll(Money[] purse, int price) //Сколько шт. можно купить на деньги
        {
            return (ShowAllMoney(purse) / price);
        }
        public int ShowAllMoney(Money[] purse)
        {
            // Переменная для хранения суммы банкнот
            int sum = 0;

            // Цикл считающий сумму всех банкнот
            foreach (Money i in purse)
            {
                // Сумма увеличивается на произведение номинала на колличество
                sum += i.nominal * i.count;
            }

            //Вернуть сумму
            return sum;
        }
        public int Banknote         //Свойства: получает значение полей
        {
            get
            {
                // Вернуть номинал банкноты
                return nominal;
            }

            set
            {
                // Установить номинал банкноты
                nominal = value;
            }
        }
        public int Number             // Свойства: чтение номинала банкнот и колличества
        {
            get
            {
                // Вернуть номинал банкноты
                return count;
            }


        }
        public int AllMoneyBanknote                         //Свойство расчитать сумму денег
        {
            get
            {
                //Вернуть сумму банкнот данного номинала
                return nominal * count;
            }
        }
        public static Money operator ++(Money t)
        {//перегрузка  ++
            t.nominal = t.nominal + 1;
            t.count = t.count + 1;
            return t;
        }
        public static Money operator --(Money t)
        {//перегрузка --
            t.nominal = t.nominal - 1;
            t.count = t.count - 1;
            return t;
        }
        public static bool operator !(Money t)
        {//перегрузка !
            if (t.count != 0) return true;
            else return false;
        }
        public static Money operator +(Money t, int skalyar)
        {//перегрузка +
            t.count += skalyar;
            return t;
        }
        public static explicit operator string(Money t)
        {
            return t.nominal + " " + t.nominal;
        }
        public static explicit operator Money(string t)
        { //перегрузка- money в string
            string[] m = t.Split(' ');
            Money M = new Money(int.Parse(m[0]), int.Parse(m[1]));
            return M;
        }
    }
}
