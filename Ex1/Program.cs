//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




int Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
int GetNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = GetNumber("Введите число: ");
int numberB = GetNumber("Введите число ");

int NaturalDegree = Degree(numberA, numberB);

Console.WriteLine("Число: " + NaturalDegree);