using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork4
{
    class Money
    {
        // Поля: номинал купюры, количество купюр
        int first;
        int second;

        // Конструктор, позволяющий создать экземпляр класса  с заданными значениям полей.
        public Money(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        //Методы, позволяющие:	вывести номинал и количество купюр;
        public void Show()
        {
            Console.WriteLine("Номинал купюры = {0}, количество купюр = {1}", first, second);
        }

        // определить, хватит ли денежных средств на покупку товара на сумму N тенге.
        public string IsEnough(int sum)
        {
            if (first * second > sum)
                return "Хватит";
            return "Не хватит";
        }

        // определить, сколько штук товара стоимости n тенге можно купить на имеющиеся денежные средства.
        public int Product_Amount(int product_price)
        {
            return (int)((first * second) / product_price);
        }

        // Свойства: позволяющее получить-установить значение полей (доступное для чтения и записи);
        public int First
        {
            set { first = value; }
            get { return first; }
        }

        public int Second
        {
            set { second = value; }
            get { return second; }
        }

        //позволяющее расчитатать сумму денег (доступное только для чтения).
        public int Total { get { return first * second; } }

        class Program
        {
            static void Main(string[] args)
            {
                int first, second;

                Console.Write("Введите номинал купюры: ");
                first = int.Parse(Console.ReadLine());
                Console.Write("Введите количество купюр: ");
                second = int.Parse(Console.ReadLine());
                Money obj = new Money(first, second);

                Console.WriteLine("\nВывести номинал и количество купюр: ");
                obj.Show();

                Console.WriteLine("\nВведите сумму на которую небоходимо купить товара: ");
                int sum = int.Parse(Console.ReadLine());
                Console.WriteLine(obj.IsEnough(sum));

                Console.WriteLine("\nВведите цену товара, который необходимо купить:");
                int product_price = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы можете купить {0} шт.\n", obj.Product_Amount(product_price));
                Console.ReadLine();
            }
        }
    }
}
