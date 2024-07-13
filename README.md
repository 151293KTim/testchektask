
# Программа для фильтрации массива строк
### Описание задачи

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых либо меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
### Пример

```
Введите количество элементов: 4
Введите 1 элемент: hello
Введите 2 элемент: 2
Введите 3 элемент: world
Введите 4 элемент: 123
Вывод: 2 123
```
### Код программы

```
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов: ");
        int num = int.Parse(Console.ReadLine());

        string[] arraystr(int size)
        {
            string[] array = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент: ");
                array[i] = Console.ReadLine();
            }
            return array;
        }

        void arrayprint(string[] array)
        {
            foreach (var item in array)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();
        }

        string[] arrayrezult(int size, string[] array)
        {
            string[] newarray = new string[size];
            int index = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i].Length <= 3)
                {
                    newarray[index] = array[i];
                    index++;
                }
            }
            Array.Resize(ref newarray, index);
            return newarray;
        }

        string[] mass = arraystr(num);
        Console.WriteLine("Исходный массив:");
        arrayprint(mass);

        string[] newmass = arrayrezult(num, mass);
        Console.WriteLine("Массив строк, длина которых меньше или равна 3 символам:");
        arrayprint(newmass);
    }
}
```
### Взаимодействие функций в программе

Программа состоит из нескольких функций, каждая из которых выполняет свою задачу. Ниже описано, как они взаимодействуют между собой:
1. Main функция

Функция Main является точкой входа в программу. В ней происходит вызов всех остальных функций, а также обработка ввода и вывода данных.

```
static void Main(string[] args)
{
    Console.WriteLine("Введите количество элементов: ");
    int num = int.Parse(Console.ReadLine());

    string[] mass = arraystr(num);
    Console.WriteLine("Исходный массив:");
    arrayprint(mass);

    string[] newmass = arrayrezult(num, mass);
    Console.WriteLine("Массив строк, длина которых меньше или равна 3 символам:");
    arrayprint(newmass);
}
```
2. Функция arraystr

Эта функция отвечает за создание и заполнение исходного массива строк. Она принимает на вход количество элементов массива (size) и возвращает массив строк.

```
string[] arraystr(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
```
3. Функция arrayprint

Функция arrayprint отвечает за вывод массива строк на экран. Она принимает массив строк и выводит его элементы через пробел.

```
void arrayprint(string[] array)
{
    foreach (var item in array)
    {
        if (!string.IsNullOrEmpty(item))
        {
            Console.Write($"{item} ");
        }
    }
    Console.WriteLine();
}
```
4. Функция arrayrezult

Эта функция формирует новый массив из строк, длина которых меньше или равна 3 символам. Она принимает на вход исходный массив строк и его размер, а возвращает новый массив, содержащий только те строки, которые удовлетворяют условию.

```
string[] arrayrezult(int size, string[] array)
{
    string[] newarray = new string[size];
    int index = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[index] = array[i];
            index++;
        }
    }
    Array.Resize(ref newarray, index);
    return newarray;
}
```
### Взаимодействие функций

    1. Ввод данных: В функции Main запрашивается количество элементов массива (num), после чего вызывается функция arraystr, которая запрашивает у пользователя элементы массива и возвращает заполненный массив строк (mass).

    2. Вывод исходного массива: После получения исходного массива, функция Main вызывает функцию arrayprint, чтобы вывести на экран исходный массив строк.

    3. Фильтрация массива: Функция Main вызывает функцию arrayrezult, передавая ей исходный массив и его размер. Функция arrayrezult создает новый массив, содержащий только строки длиной меньше или равной 3 символам, и возвращает его.

    4. Вывод нового массива: После получения нового массива, функция Main снова вызывает функцию arrayprint, чтобы вывести на экран отфильтрованный массив строк.

Таким образом, функции работают совместно, чтобы создать массив строк, отфильтровать его и вывести результаты на экран.
### Инструкции по запуску

1. Скопируйте код в файл с расширением .cs (например, Program.cs).
2. Откройте терминал и перейдите в каталог, где находится файл.
3. Запустите программу командой dotnet run.

### Заключение

Этот код представляет собой простую консольную программу на языке C#, которая позволяет пользователю вводить массив строк и фильтровать его, оставляя только строки длиной меньше или равной 3 символам. 