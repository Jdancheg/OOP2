using System;

namespace BankApp
{
    class Program
    {
        static void Main()
        {

            // Урок №2
            /*
            BankAccount account = new BankAccount(AccountType.savings, 200);
            Console.WriteLine("Проверяем вывод баланса: ");
            Console.WriteLine(account.Balance);
            Console.WriteLine("Вывод типа счета: ");
            Console.WriteLine(account.AccountType.ToString());
            Console.WriteLine("Пытаемся установить баланс в -500: ");
            account.Balance = -500;
            Console.WriteLine("Пытаемся установить баланс в -500: ");
            account.Balance = 500;
            Console.WriteLine(account.Balance);
            Console.WriteLine("Кладем на счет 100: ");            
            account.PutToDeposit(100);
            Console.WriteLine("Снимаем со счета 2300: ");
            account.Widthraw(2300);
            Console.WriteLine("Снимаем со счета 23: ");
            account.Widthraw(23);    
            */


            // Урок №3            
            BankAccount account = new BankAccount(2000);
            BankAccount account1 = new BankAccount(100);
            BankAccount account2 = new BankAccount(100);

            Console.WriteLine("Тест 1");
            try
            {
                account1.AddMoneyFromAnotherAcc(account, 1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("Тест 2");
            try
            {
                account1.AddMoneyFromAnotherAcc(account2, 1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }         


            Console.WriteLine("Реверсирование строки Hello World!!!");
            Console.WriteLine(Lesson3.ReverseStr("Hello World!!!"));

            Console.ReadKey();
        }
    }
}
