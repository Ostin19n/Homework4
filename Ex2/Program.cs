// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumNumber(int numberN)
  {  
    int a = Convert.ToString(numberN).Length;
    int b = 0;
    int result = 0;

    for (int i = 0; i < a; i++)
    {
      b = numberN - numberN % 10;
      result = result + (numberN - b);
      numberN = numberN / 10;
    }
     return result;
  }

int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
    int numberN = GetNum("Введите число ");

    int sumNum = SumNumber(numberN);

    Console.WriteLine("Сумма чисел " + sumNum);
