// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next();
int firstThreeDigitNumber = 100;
if (num < firstThreeDigitNumber)
{
    System.Console.WriteLine($"{num} -> Третьей цифры нет");
}
else
{
    int temp = num;
    int lastThreeDigitNumber = 999;
    while (temp > lastThreeDigitNumber)
    {
        temp = temp / 10;
    }
    int result = temp % 10;
    System.Console.WriteLine($"{num} -> {result}");
}