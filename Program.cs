/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. Не применять строки!

14212 -> нет
12821 -> да
23432 -> да*/

int Prompt(string massage)
{
	Console.Write(massage);
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

int Reverse(int number) //метод для переворачивания числа
{ 
    int reverse = 0;
    while (number > 0)
    {
        int value = number % 10;
        reverse = reverse * 10 + value;
        number = number / 10;
    }
return reverse; // возвращает перевернутое число
}

bool Palindrome(int number) // метод для определения палиндрома
{
    return number == Reverse(number);
}

int number = Prompt("Введите число -> ");
if (Palindrome(number))
{
    Console.WriteLine ($"число {number} является палиндромом");
}
else
{
    Console.WriteLine ($"число {number} не является палиндромом");
}
