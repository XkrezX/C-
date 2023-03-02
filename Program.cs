using System;

class Program
{
    static void Main(string[] args)
    {
        #region Дана строка символов. Необходимо проверить, является ли эта строка палиндромом.
        Console.Write("Введите строку: ");
        string str = Console.ReadLine();

       
        bool isPalindrome = true;
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

      
        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом");
        }

        Console.ReadKey();
        #endregion
    }
}