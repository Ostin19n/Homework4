// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumNumber(int numberN)
  {  
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
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
