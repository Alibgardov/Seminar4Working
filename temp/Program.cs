Console.Clear();
Console.Write("Введите целое число number:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum += i; //sum = sum +1;
}
Console.WriteLine($"сумма чисел от единицы до number == {sum}");



// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36