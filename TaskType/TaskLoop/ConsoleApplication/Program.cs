﻿// Невыполненные задачи - ////////////////////////////////////(после них), но попытки были


{//задача 1
    int number = 0;
    for (int i = 0; i <= 50; i++)
    {
        Console.WriteLine(i);
    }
    number = default;
    Console.WriteLine("while");
    while (number < 50) ;
    {
        Console.WriteLine(++number);
    }
}
// 2. [1, 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами
{
    int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
    for (int i = 0; i < array1.Length; i++)
    {
        System.Console.WriteLine(array1[i]);
    }
    // while ()
    int index = 0;
    while (index < array1.Length)
    {
        System.Console.WriteLine(array1[index++]);
    }

    foreach (int item in array1)
    {
        System.Console.WriteLine(item);
    }
}

//3. Дан массив с элементами [2, 3, 4, 5]. С помощью 3 циклов найдите произведение
// элементов этого массива.
{
    int[] array = new int[4] { 2, 3, 4, 5 };
    int i = 0;
    int result = 1;
    while (i < array.Length)
    {
        result *= array[i];
        i++;
    }
    Console.WriteLine(result);

    // ----------------------
    result = 1;
    for (int j = 0; j < array.Length; j++)
    {
        result *= array[j];
    }
    Console.WriteLine(result);
    //------------------------
    foreach (int item in array)
    {
        result *= item;
    }
    Console.WriteLine(result);
}
// 4. Выведите столбец чисел от 11 до 33 циклом while
{
    for (int i = 11; i <= 33; i++)
    {
        System.Console.WriteLine(i);
    }
}
//--------------------
{
    int number;
    int i = 11;
    while (11 <= i && i <= 33)
    {
        System.Console.WriteLine(i++);
    }
}

// 5. Выведите столбец четных чисел в промежутке от 0 до 100 (for)
{
    int[] array1 = new int[101];
    for (int i = 0; i <= array1.Length; i++)
    {
        System.Console.WriteLine(i);
    }
}

// 6. С помощью цикла while найдите сумму чисел от 1 до 100.
{
    int difference = 0;
    int i = 1;
    while (1 <= i && i <= 100)
    {
        System.Console.WriteLine(difference += i);
        i++;
    }
}

// 7. Дан массив с элементами [1, 2, 3, 4, 5]. С помощью цикла for of найдите сумму
// элементов этого массива
{
    int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
    int difference = 0;
    for (int i = 0; i <= array1.Length; i++)
    {
        System.Console.WriteLine(difference += i);
    }
}

// 8. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 3 циклом foreach in 
{
    int[] items = new int[6] { 2, 5, 9, 15, 0, 4 };
    foreach (int item in items)
    {
        int difference = item % 3;
        if (difference == 0)
        {
            System.Console.WriteLine(item);
        }
    }
}

// 9. Дан массив с элементами [1, 2, 2, 3, 4, 4, 3, 4, 5]. Выведите только уникальные
// значения массива -> [1, 5] (for)
{
    int[] array = new int[9] { 1, 2, 2, 3, 4, 4, 3, 4, 5 };
    for (int i = 0; i <= array.Length; i++)
    {
        if (i == 1 || i == 5)
        {
            System.Console.WriteLine(i);
        }
    }
}

// 10. Дан массив 2, 5, 9, 15, 0, 4. Выведите все числа кратные 5 циклом while
{
    int[] array = new int[6] { 2, 5, 9, 15, 0, 4 };
    int number = 1;
    while (number <= array.Length)
    {
        if (number % 5 == 0)
        {
            Console.WriteLine(number);
            number++;
        }
    }
}
///////////////////////////////////////////////

// Пример из презентации
// int number = 2;
// while (number % 5 != 0)
// {
//     System.Console.WriteLine(number);
//     number++;
// }
// }

// 11. Дан массив с числами. Числа могут быть положительными и отрицательными.
// Найдите сумму всех положительных элементов массива циклом foreach in

// 12. Дан массив числами, например: [10, 20, 30, 50, 235, 3000]. Выведите на экран только
// те числа из массива, которые начинаются на цифру 1, 2 или 5 -> 10, 20, 50, 235


// 13. Дан массив с элементами 1, 2, 3, 4, 5, 6, 7, 8, 9. С помощью цикла for создайте строку '-1-2-3-4-5-6-7-8-9-‘
{
    int[] array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    for (int i = 1; i <= array.Length; i++)
    {
        System.Console.Write($"{i}-");
    }
}

// 14. Дано число 7, найдите все числа кратные 7 до 100
{
    int[] array = new int[100];
    for (int i = 7; i <= array.Length; i++)
    {
        if (i % 7 == 0)
        {
            System.Console.WriteLine(i);
        }
    }
}

// 15. Дано предложение и количество раз которое его надо повторить. Напишите
// программу, которая повторяет данное предложение нужное количество раз.



// пример из презентации(do while)
// int number;
// string? text;
//do
//{
//   System.Console.WriteLine("enter number");
//     text = Console.ReadLine();
// }
// while ();
////////////////////////////////////////////////////////////////////

// 16. Пользователь вводит число, являющееся количеством элементов будущего
// массива и выбирает тип данных массива. Напишите код заполнения массива
// выбранным типом данных.


// 17. Пользователь вводит число, являющееся количеством элементов будущего
// массива. Напишите код заполнения массива. Записать в массив только числа.


// 18. Пользователь вводит многозначное число. Необходимо вставить двоеточие
// между двумя нечетными числами. Работать с числом как с массивом. Использовать for
// 55639217 -> 5:563:921:7.
{
    string? consoleText = Console.ReadLine();
    consoleText = consoleText?.Trim();
    if (long.TryParse(consoleText, out _))
    {
        char[] arrayChars = consoleText.ToCharArray();
        string result = arrayChars[0].ToString();
        for (int i = 1; i < arrayChars.Length; i++)
        {
            int prevNumber = int.Parse(Convert.ToString(arrayChars[i - 1]));
            int currentNumber = int.Parse(arrayChars[i].ToString());
            // if (prevNumber % 2 == 1 && currentNumber % 2 == 1)
            // {
            //     result += ":";
            // }
            // result += arrayChars[i];


            result += prevNumber % 2 == 1 && currentNumber % 2 == 1 ? $":{arrayChars[i]}" : arrayChars[i];
        }
        result += ".";
        System.Console.WriteLine(result);
    }
}


{
    object[] items = new object[6];
    for (int i = 0; i < items.Length; i++)
    {
        string? text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            items[i] = number;
        }

    }

    System.Console.WriteLine(string.Join(", ", items));
}



// // {
// //   difference -= items[index++] is int number ? number : default;
// // -----------------------------------равнозначно---------------------------
// // difference -= items[index] is int number ? number : default;
// // index++;
// // }

{
    int countIteration = 0;
    int sumNumbers = 0;
    while (sumNumbers <= 100)
    {
        countIteration++;
        int number = new Random().Next(1, 8);
        if (number % 2 == 1)

        {
            continue;
        }
        sumNumbers += number;

    }
    System.Console.WriteLine(countIteration);
    System.Console.WriteLine(sumNumbers);
}

{
    int[] numbers = { 456, 43, 34, 4345 };
    System.Console.WriteLine(string.Join(" , ", numbers));
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            numbers[i] /= 2;
        }
        else
        {
            numbers[i] += 10;
        }
        System.Console.WriteLine(string.Join(" , ", numbers));
        int index = 0;
        while (index < numbers.Length)
        {
            numbers[index] = numbers[index] % 2 == 0 ? numbers[index] /= 2 : numbers[index] += 10;
            index++;
        }
        System.Console.WriteLine(string.Join(" , ", numbers));
    }
}

{
    string[] array = {"dfgh", "fghj", "sdfg", "gh"};
    string result = "0";
    for (int i = 0; i < array.Length; i++ )
    {
        result += array[i];
    }
}

// сложить строки, чтобы были / и в начале добавить http//
// { 'github.com', 'HannaPleshko' }
// github.com/HannaPleshko
// https://
{
    string[] array = { "github.com", "HannaPleshko" };
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i] + "/";
    }
    result = result.Remove(result.Length - 1);
    System.Console.WriteLine($"https://{result}");
}
{
    string[] array = { "github.com", "HannaPleshko" };
    string result = "";
    int i = 0;
    while (i < array.Length)
    {
        result += array[i] + "/";
        i++;
    }
    result = result.Remove(result.Length - 1);
    System.Console.WriteLine($"https://{result}");
}
{
int number;
string? consoleText;
do
{
    Console.Write("Введите число от 1 до 10: ");
    consoleText = Console.ReadLine();
}
while (!int.TryParse(consoleText, out number) || number < 1 || number > 10);
}
//----------------------------------------------------
{
    int number;
    bool stopLoop = false;

    while (!stopLoop)
    {
        Console.Write("Введите число от 1 до 10: ");
        string? consoleText = Console.ReadLine();
        stopLoop = int.TryParse(consoleText, out number) && number >= 1 && number <= 10;
    }
}
//-----------развернутый do-while в while-----------------------------------------
{
    int number;

    Console.Write("Введите число от 1 до 10: ");
    string? consoleText = Console.ReadLine();

    while (!int.TryParse(consoleText, out number) || number < 1 || number > 10)
    {
        Console.Write("Введите число от 1 до 10: ");
        consoleText = Console.ReadLine();
    }
}


{
    Console.WriteLine("Задача 9");
    string? str = Console.ReadLine();
    string? str1 = Console.ReadLine();
    int irt;
    int irt1;
    string? oper = "";
    if (int.TryParse(str, out irt) && int.TryParse(str1, out irt1))
    {
        do
        {
            oper = Console.ReadLine();
            if (!String.IsNullOrEmpty(oper))
            {
                switch (oper)
                {
                    case "+":
                        Console.WriteLine(irt + irt1);
                        break;
                    case "-":
                        Console.WriteLine(irt - irt1);
                        break;
                    case "/":
                        Console.WriteLine(irt / irt1);
                        break;
                    case "*":
                        Console.WriteLine(irt * irt1);
                        break;
                    case "%":
                        Console.WriteLine(irt % irt1);
                        break;
                    case "!":
                        Console.WriteLine(irt != irt1);
                        break;
                }
            }
        }
        while (oper == "0");
    }
    else { Console.WriteLine("Одна из строк is not число"); }
}



{
System.Console.WriteLine("Начало");
string? operatorNumbers;
do
{
    int number1 = new Random().Next(0, 100);
    int number2 = new Random().Next(0, 100);

    System.Console.WriteLine("Введите арифметический оператор");
    System.Console.WriteLine("+: сумма");
    System.Console.WriteLine("-: разность");
    System.Console.WriteLine("*: умножение");
    System.Console.WriteLine("/: деление");
    System.Console.WriteLine("%: остаток от деления");
    System.Console.WriteLine("&: бинарный оператор");

    System.Console.WriteLine("0: выход");

    operatorNumbers = Console.ReadLine();
    System.Console.WriteLine($"number1 = {number1}; number2 = {number2}");
    if (operatorNumbers == "+")
    {
        System.Console.WriteLine(number1 + number2);
    }
    else if (operatorNumbers == "&")
    {
        System.Console.WriteLine(number1 & number2);
    }
    else if (operatorNumbers == "/" && number2 != 0)
    {
        System.Console.WriteLine(number1 / number2);
    }


} while (operatorNumbers != "0"); //0 != 0 
System.Console.WriteLine("Конец");
//доделать!!!
}