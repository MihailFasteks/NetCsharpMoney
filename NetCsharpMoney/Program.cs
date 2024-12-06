// See https://aka.ms/new-console-template for more information
using NetCsharpMoney;

Money money1 = new Money(100.50);
Money money2 = new Money(50.75);

while (true)
{
    Console.Clear();
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Сложение двух объектов ");
    Console.WriteLine("2. Увеличение Money на 0.01 ++");
    Console.WriteLine("3. Вычитание двух объектов Money ");
    Console.WriteLine("4. Вычитание числа из Money ");
    Console.WriteLine("5. Сложение Money с числом ");
    Console.WriteLine("6. Сравнение Money ");
    Console.WriteLine("0. Выход");
    Console.Write("Выберите действие: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine($"money1: {money1.Sum}, money2: {money2.Sum}");
            Money resultAdd = money1 + money2;
            Console.WriteLine($"Результат сложения: {resultAdd.Sum}");
            break;

        case 2:
            Console.WriteLine($"Исходная сумма money1: {money1.Sum}");
            money1++;
            Console.WriteLine($"После увеличения: {money1.Sum}");
            break;

        case 3:
            Console.WriteLine($"money1: {money1.Sum}, money2: {money2.Sum}");
            Money resultSub = money1 - money2;
            Console.WriteLine($"Результат вычитания: {resultSub.Sum}");
            break;

        case 4:
            Console.Write("Введите число для вычитания: ");
            int subtractValue = int.Parse(Console.ReadLine());
            Money resultSubInt = money1 - subtractValue;
            Console.WriteLine($"Результат вычитания числа: {resultSubInt.Sum}");
            break;

        case 5:
            Console.Write("Введите число для сложения: ");
            int addValue = int.Parse(Console.ReadLine());
            Money resultAddInt = money1 + addValue;
            Console.WriteLine($"Результат сложения числа: {resultAddInt.Sum}");
            break;

        case 6:
            Console.WriteLine($"money1: {money1.Sum}, money2: {money2.Sum}");
            Console.WriteLine($"money1 < money2: {money1 < money2}");
            Console.WriteLine($"money1 > money2: {money1 > money2}");
            Console.WriteLine($"money1 == money2: {money1 == money2}");
            Console.WriteLine($"money1 != money2: {money1 != money2}");
            break;

        case 0:
            Console.WriteLine("Выход из программы...");
            return;

        default:
            Console.WriteLine("Неверный выбор. Попробуйте снова.");
            break;
    }

    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
    Console.ReadKey();
}
