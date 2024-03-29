﻿// 1.Найти максимальное число из 2 введенных (2 способа)
// Первый способ
{
    Console.WriteLine("Введите первое число:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Math.Max(number1, number2));
}
//Второй способ
{
    Console.WriteLine("Введите первое число:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2)
    {
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine(number2);
    }
}

// 2.Выявить является ли введенное число четным
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    number = number % 2;
    string result = number == 0 ? "число чётное" : "число нечётное";
    Console.WriteLine(result);
}
//второй способ
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (!string.IsNullOrEmpty(Convert.ToString(number)))
    {
        if (number % 2 == 0)
        {
            System.Console.WriteLine("число чётное");
        }
        else
        {
            System.Console.WriteLine("число нечётное");
        }
    }
    else
    {
        System.Console.WriteLine("Пусто");
    }
}


// 3. Пользователь вводит число от 1 до 7, соответствующее дню недели. Необходимо
// вывести день для введенного числа.
{
    Console.WriteLine("Введите число от 1 до 7 :");
    int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
    if (!string.IsNullOrEmpty(Convert.ToString(dayOfTheWeek)))
    {
        string? day = dayOfTheWeek
        switch
        {
            0 or > 7 or < 0 => "Неверно введено число",
            1 => "понедельник",
            2 => "вторник",
            3 => "среда",
            4 => "четверг",
            5 => "пятница",
            6 => "суббота",
            7 => "воскресенье"
        };
        System.Console.WriteLine(day);
    }
    else
    {
        System.Console.WriteLine("Пусто");
    }
}

// 4. Есть строка в 3 символа. Написать проверку если число, вывести true, в
// противном случае false (Char.IsDigit(str2, position))
{
    Console.WriteLine("Введите число");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        if (text?.Length <= 3)
        {
            if (int.TryParse(text, out int value))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        else
        {
            System.Console.WriteLine("Слишком большое число, попробуйте ввести трехзначное");
        }
    }
    else
    {
        System.Console.WriteLine("Пусто...");
    }
}
// 5 Пользователь вводит число с клавиатуры. Нужно вывести на экран сколько в этом 
// числе цифр, а также положительное оно или отрицательное. Например, "Число " + 
// num + " однозначное положительное". (Length)
{
    Console.WriteLine("Введите число ");
    string? text = Console.ReadLine();
    int length = text?.Length ?? default;
    if (!string.IsNullOrEmpty(Convert.ToString(text)))
    {
        if (int.TryParse(text, out int value))
        {
            if (value > 0)
            {
                Console.Write($"Число {value} - {length} символов. Однозначно положительное ");
            }
            else
            {
                Console.Write($"Число {value} - {length} символов. Однозначно отрицательное ");
            }
        }
    }
    else
    {
        System.Console.WriteLine("Пусто...");
    }
}


// 6.Найти квадратный корень числа. Если же число без плавающей точки, то просто
// вывести его. В противном случае необходимо округлить число до целых.
// Добавить проверку на ввод только чисел
{
    System.Console.WriteLine("Введите число");
    string? number = Console.ReadLine();
    if (!string.IsNullOrEmpty(number))
    {
        if (int.TryParse(number, out int number1))
        {
            System.Console.WriteLine(Math.Sqrt(number1));
        }
        else
        {
            System.Console.WriteLine("Вы ввели не число");
        }
    }
    else
    {
        System.Console.WriteLine("Пусто...");
    }
}

// 7. Два автомобиля едут друг к другу с постоянными скоростями V1 и V2 км/ч.
// Определите, через какое время автомобили встретятся, если расстояние между
// ними равно S км. Добавить проверку на ввод только чисел
{
    Console.WriteLine("Введите первую скорость");
    string? speed1 = Console.ReadLine();
    Console.WriteLine("Введите вторую скорость");
    string? speed2 = Console.ReadLine();
    Console.WriteLine("Введите расстояние между автомобилями");
    string? distance = Console.ReadLine();
    if (!string.IsNullOrEmpty(speed1) && !string.IsNullOrEmpty(speed2) && !string.IsNullOrEmpty(distance))
    {
        if (int.TryParse(speed1, out int speedFirst) && int.TryParse(speed2, out int speedSecond) && int.TryParse(distance, out int distance1))
        {
            int result = distance1 / (speedFirst + speedSecond);
            System.Console.WriteLine($"{result} ч`");
        }
        else
        {
            System.Console.WriteLine("Не число");
        }
    }
    else
    {
        System.Console.WriteLine("Пусто...");
    }
}

// 8. Пользователь вводит номер месяц. Необходимо вывести пору года по номеру
// месяца (2 способа)
{
    System.Console.WriteLine("Введите номер месяца");
    int numberMonth = Convert.ToInt32(Console.ReadLine());
    if (!string.IsNullOrEmpty(Convert.ToString(numberMonth)))
    {
        if (numberMonth == 1 || numberMonth == 2 || numberMonth == 12)
        {
            System.Console.WriteLine("winter");
        }
        else if ((numberMonth == 3 || numberMonth == 4 || numberMonth == 5))
        {
            System.Console.WriteLine("spring");
        }
        else if ((numberMonth == 6 || numberMonth == 7 || numberMonth == 8))
        {
            System.Console.WriteLine("summer");
        }
        else
        {
            System.Console.WriteLine("autumn");
        }

    }
    else
    {
        System.Console.WriteLine("Пусто...");
    }
}

{
    System.Console.WriteLine("Введите номер месяца");
    int numberMonth = Convert.ToInt32(Console.ReadLine());
    if (string.IsNullOrEmpty(Convert.ToString(numberMonth)))
    {
        string? month = numberMonth switch
        {
            0 or > 12 or < 0 => "Неверно введено число",
            1 => "winter",
            2 => "winter",
            3 => "spring",
            4 => "spring",
            5 => "spring",
            6 => "summer",
            7 => "summer",
            8 => "summer",
            9 => "autumn",
            10 => "autumn",
            11 => "autumn",
            12 => "winter"
        };
        System.Console.WriteLine(month);
    }
    else
    {
        System.Console.WriteLine("Пусто...");
    }
}

// 9.Пользователь вводит число: 1, 2, 3 или 4.Если это значение ‘2', то вывести в
// консоль 'зима близко', ‘3' – зима, ‘4' – всё' . Решите задачу через switch-case.
{
    System.Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (!string.IsNullOrEmpty(Convert.ToString(number)))
    {
        if (number <= 4 || number >= 0)
        {
            if (number == 1)
            {
                System.Console.WriteLine("");
            }
            else if (number == 2)
            {
                System.Console.WriteLine("зима близко");
            }
            else if (number == 3)
            {
                System.Console.WriteLine("зима");
            }
            else if (number == 4)
            {
                System.Console.WriteLine("всё");
            }
            else
            {
                System.Console.WriteLine();
            }
        }
        else
        {
            System.Console.WriteLine("Вы ввели неверное число");
        }
    }
    else
    {
        System.Console.WriteLine("Пусто...");
    }
}
{
    {
        System.Console.WriteLine("Введите число");
        string? number = Console.ReadLine();
        if (string.IsNullOrEmpty(number))
        {
            System.Console.WriteLine("Пустая строка");
        }
        else
        {
            switch (number)
            {
                case "1":
                    System.Console.WriteLine("");
                    break;
                case "2":
                    System.Console.WriteLine("Зима близко");
                    break;
                case "3":
                    System.Console.WriteLine("Зима");
                    break;
                case "4":
                    System.Console.WriteLine("Все");
                    break;
                default:
                    System.Console.WriteLine("Ошибка ввода");
                    break;
            }
        }
    }
}
{
    System.Console.WriteLine("Введите число");
    int? number = Convert.ToInt32(Console.ReadLine());
    if (string.IsNullOrEmpty(Convert.ToString(number)))
    {
        System.Console.WriteLine("Пусто...");
    }
    else
    {
        string result = number switch
        {
            1 => "Ничего",
            2 => "Зима близко",
            3 => "Зима",
            4 => "Все",
            > 4 or < 0 => "Неверно введено число"
        };
    }
}
// 10. Пользователь вводит одно число. Необходимо вывести обратное ему (число
// является обратным при 1/x). Если при этом введённое с клавиатуры число – ноль,
// то вывести «Обратного числа не существует».
{
    System.Console.WriteLine("Введите число");
    double number = Convert.ToDouble(Console.ReadLine());
    if (!string.IsNullOrEmpty(Convert.ToString(number)))
    {
        if (number > 0)
        {
            System.Console.WriteLine(1 / number);
        }
        else if (number == 0)
        {
            System.Console.WriteLine("Обратного числа не существует");
        }
    }
    else
    {
        System.Console.WriteLine("Пусто");
    }
}

// 11. Напишите программу, которая находит полное число метров по заданному числу
// сантиметров. Добавить проверку на ввод только чисел
// 345 -> 3
// 100 -> 1
{
    System.Console.WriteLine("введите длины в сантиметрах");
    string? number = Console.ReadLine();
    if (!string.IsNullOrEmpty(number))
    {
        if (int.TryParse(number, out int number1))
        {
            int result = number1 / 100;
            if (result < 1)
            {
                System.Console.WriteLine("меньше метра");
            }
            else
            {
                System.Console.WriteLine(result);
            }
        }
        else
        {
            System.Console.WriteLine("вы ввели не число");
        }
    }
    else
    {
        System.Console.WriteLine("Пусто");
    }
}

// 12. Напишите программу, в которой рассчитывается сумма и произведение цифр
// положительного трёхзначного числа
// 123 -> Сумма цифр = 6 Произведение цифр = 6
{
    Console.WriteLine("Введите положительное трехзначное число");
    string? text = Console.ReadLine();
    int sum = 0;
    int inc = 1;
    if (!string.IsNullOrEmpty(text))
    {
        if (text?.Length <= 3 && Convert.ToInt32(text) > 0)
        {
            for (int i = 0; i < text?.Length; i++)
            {
                if (int.TryParse(Convert.ToString(text[i]), out int number))
                {
                    sum += number;
                    inc *= number;
                }
            }
            System.Console.WriteLine($"Сумма цифр ={sum}, Произведение цифр = {inc} ");
        }
        else
        {
            System.Console.WriteLine("error");
        }
    }
    else
    {
        System.Console.WriteLine("error");
    }
}

// 13. Пользователь вводит четырехзначное число. Напишите код, который будет
// выявлять является ли каждое составляющее числа четным либо нечетным.
// Добавить проверку на ввод только чисел
// 1234 -> 1 – неч 2 – чет 3 – неч 4 - чет
{
    Console.WriteLine("Введите число");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        for (int i = 0; i < text?.Length; i++)
        {
            if (int.TryParse(Convert.ToString(text[i]), out int number))
            {
                if (number % 2 == 0)
                {
                    System.Console.WriteLine($"{number} - четное");
                }
                else if (number % 2 != 0)
                {
                    System.Console.WriteLine($"{number} - нечетное");
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine("error");
    }
}

// 14. Пользователь вводит 2 числа от 0 до 10. Сложите переменные так, чтобы в
// результате получилось выражение: “I’m хх". Проверки на ввод только чисел.
// Проверки на ввод чисел до 10. Если первое число – 0, то опустить его
{
    Console.WriteLine("Введите первое число");
    string? number1 = Console.ReadLine();
    Console.WriteLine("Введите первое число");
    string? number2 = Console.ReadLine();
    if (!string.IsNullOrEmpty(number1) && !string.IsNullOrEmpty(number2))
    {
        if (int.TryParse(number1, out int number3) && int.TryParse(number2, out int number4))
        {
            if (number3 >= 0 && number3 >= 0 && number4 >= 0 && number4 <= 10)
            {
                Console.WriteLine($"I’m {number4}");
            }
            else
            {
                Console.WriteLine($"I’m {number3}{number4}");
            }
        }
        else
        {
            Console.WriteLine("Ваше число меньше нуля или больше десяти");
        }
    }
    else
    {
        System.Console.WriteLine("error");
    }
}

// 15. Пользователь вводит строку. Необходимо сделать проверку, что это не число и
// вывести длину строки
{
    Console.WriteLine("Введите строку ");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        if (!int.TryParse(text, out _))
        {
            if (!string.IsNullOrEmpty(text))
            {
                Console.WriteLine($"Длинна строки {text.Length}");
            }
            else
            {
                Console.WriteLine("пустота");
            }
        }
        else
        {
            Console.WriteLine("ввели число");
        }
    }
    else
    {
        System.Console.WriteLine("error");
    }
}
// 16. Пользователь вводит строку. Вывести первый символ строки (индексы)
{
    string? value = Console.ReadLine();
    if (!string.IsNullOrEmpty(value))
    {
        Console.WriteLine(value?[0]);
    }
    else
    {
        System.Console.WriteLine("error");
    }
}
// 17.Пользователь вводит строку.Необходимо сделать проверку, что это не число и
// вывести текущую строку в большом регистре
{
    System.Console.WriteLine("введите стоку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        if (int.TryParse(text, out int text1))
        {
            System.Console.WriteLine("это число");
        }
        else
        {
            System.Console.WriteLine(text?.ToUpper());
        }
    }
    else
    {
        System.Console.WriteLine("error");
    }
}

// 18. Пользователь вводит строку.Необходимо повторить ее трижды
{
    System.Console.WriteLine("введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        System.Console.WriteLine(text, text, text);
    }
    else
    {
        System.Console.WriteLine("error");
    }
}

// 19. Ввести строку. Проверить является ли это число или текст.Если число, то
// выяснить, четное или нет.Если это текст и равен “hschool”, вывести true. В
// противном случае false
{
    string? funfy = Console.ReadLine();
    int funfynumber;
    if (!string.IsNullOrEmpty(funfy))
    {
        if (int.TryParse(funfy, out funfynumber))
        {
            if (funfynumber % 2 == 0)
            {
                Console.WriteLine("Число Чёткое");
            }
            else { Console.WriteLine("Число НЕЧёткое"); }
        }
        else
        {
            if (funfy == "hschool")
            { Console.WriteLine(true); }
            else { Console.WriteLine(false); }
        }
    }
    else
    {
        System.Console.WriteLine("error");
    }
}
{
    string? funfy = Console.ReadLine();
    int funfynumber;
    if (!string.IsNullOrEmpty(funfy))
    {
        if (int.TryParse(funfy, out funfynumber))
        {
            var result = funfynumber % 2 == 0 ? "Число Чёткое" : "Число НЕЧёткое";
        }
        else
        {
            var result = funfy == "hschool" ? true : false;
        }
    }
    else
    {
        System.Console.WriteLine("error");
    }
}


// Пользователь вводит 2 числа и вводит оператор арифметический, в соответствии с ним вывести 
{
    int number1 = 2;
    int number2 = 5;
    string? oper = Console.ReadLine();
    if (string.IsNullOrEmpty(oper))
    {
        System.Console.WriteLine("Пустая строка");
    }
    else
    {
        switch (oper)
        {
            case "+":
                System.Console.WriteLine(number1 + number2);
                break;
            case "-":
                System.Console.WriteLine(number1 - number2);
                break;
            case "*":
                System.Console.WriteLine(number1 * number2);
                break;
            case "/" when number2 != 0:
                System.Console.WriteLine(number1 / number2);
                break;
            case "%":
                System.Console.WriteLine(number1 % number2);
                break;
            case "^":
                System.Console.WriteLine(Math.Pow(number1, number2));
                break;
            default:
                System.Console.WriteLine("Ошибка ввода");
                break;
        }
    }

    int number = new Random().Next(55, 777);
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        if (i == 451)
        {
            //Выход из цикла если i имеет значение 451
            break;
        }
        else if (i % 3 == 0)
        {
            //Переходим на новую итерацию цикла i++
            continue;
        }

        if (i % 4 == 0)
        {
            result += i / 4;
        }
        else if (i % 10 == 0)
        {
            result += i - 1;
        }
        else
        {
            result += i;
        }
    }
    Console.WriteLine(result);
}