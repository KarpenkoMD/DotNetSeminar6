/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

void FillFibonacciArray(int[] fibonacciArrayToFill)
{
    fibonacciArrayToFill[0] = 0;
    fibonacciArrayToFill[1] = 1;
    for (int i = 2; i < fibonacciArrayToFill.Length; i++)
    {
        fibonacciArrayToFill[i]=fibonacciArrayToFill[i-1]+
                                fibonacciArrayToFill[i-2];
    }
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
int InputN(int border)
{
    int NumberToInput = 0;
    do
    {
        Console.Write($"Введите число больше {border}: ");
        NumberToInput = Convert.ToInt32(Console.ReadLine());
        if (NumberToInput <= border)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ошибка! Нажмите любую клавишу и повторите ввод!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }

        else
        {
            return NumberToInput;
        }
    } while (true);
}

Console.Clear();
Console.WriteLine("Для вывода первых N чисел Фибоначчи");
int nFibonacci = InputN(2);

int[] fibonacciArray = new int[nFibonacci];
FillFibonacciArray(fibonacciArray);

Console.WriteLine();
PrintArray(fibonacciArray);