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
int PromptNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = PromptNumber("Введите число: ");
int numberB = PromptNumber("Введите число ");

int NaturalDegree = Degree(numberA, numberB);

Console.WriteLine("Число: " + NaturalDegree);