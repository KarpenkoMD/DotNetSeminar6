/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int InputN()
{
    int NumberToInput = 0;
    Console.Write($"Введите число: ");
    NumberToInput = Convert.ToInt32(Console.ReadLine());
    return NumberToInput;
}
void PrintArray(int[] ArrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < ArrayToPrint.Length; i++)
    {
        Console.Write($"{ArrayToPrint[i]}");
        if (i < ArrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] DecToBinConvert(int decNumberToConvert)
{
    int temp = decNumberToConvert;
    int binArraySize = 0;
    for (binArraySize = 0; temp > 0; binArraySize++)
        temp = temp / 2;
    int[] binArray = new int[binArraySize];
    for (int i = binArraySize - 1; i >= 0; i--)
    {
        binArray[i] = decNumberToConvert % 2;
        decNumberToConvert = decNumberToConvert / 2;
    }
    return binArray;
}



int decNumber = InputN();
int[] binNumberArray = DecToBinConvert(decNumber);

Console.WriteLine("Число {0} в двоичной системе:", decNumber);
PrintArray(binNumberArray);

