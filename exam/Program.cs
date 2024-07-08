//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.WriteLine("Введите количество элементов: ");
int num = int.Parse(Console.ReadLine());
string[] arraystr(int size)
{
    string [] array=new  string [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент: ");
        array[i]=Console.ReadLine();
    }
    return array;
}

string [] mass=arraystr(num);
