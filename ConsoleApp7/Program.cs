using System;
// Смирнов Александр 217
//Ввод вывод числовых данных и арифмет. операции с целыми 

    class Program
    {
        static void Main() // Начало программы
        {
        int x, y; // Объявление целых переменных

        Console.Title = "Смирнов Александр, 217";
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Clear();

        Console.WriteLine("Введите два целых"); //Вывод строки в консоль
        // Ввод данных
        Console.Write("Введите X: "); //Вывод строки в консоль
        x = Convert.ToInt32(Console.ReadLine()); //Считать строку преобразовать в целый тип присвоить X 
        Console.Write("Введите Y: "); //Вывод строки в консоль
        y = Convert.ToInt32(Console.ReadLine());

        // Выполнение расчетов
        int p = x * y;
        int s = x + y;
        int d = x / y;
        int m = x % y; // Остаток от целочисленного деления
        double r = (double) x / y; // Реальное деление и результат

        // Вывод результатов
        Console.WriteLine("______________________");
        Console.WriteLine("Значение x =" + x); // 1-й способ вывода строка + значение переменнной
        Console.WriteLine("Значение y ={0}", y); // 2-й способ
        Console.WriteLine("Произведение ={0}", p);
        Console.WriteLine("Сумма  ={0}", s);
        Console.WriteLine("Целое деление {0} / {1} = {2}", x, y, d);
        Console.WriteLine("Остаток от целочисленного деления y ={0}", m);
        Console.WriteLine("Реальное деление {0} / {1} = {2:f4}", x, y, r);


        Console.WriteLine("------------------");
        Console.WriteLine("Press any key...");
        Console.ReadKey(); // Считать клавишу в консоле перед закрытием

        }
    }

