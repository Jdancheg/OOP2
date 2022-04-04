using System;

namespace BankApp
{
    public enum AccountType     // не совсем понял, как работать с перечисляемым типом - объявлять его внутри класса, или вне его???
    {                           // если внутри, то как его передавать в конструктор?
        budget,
        foreign,
        frozen,
        insured,
        correspondent,
        savings,
        impersonal,
        total,
        consolidated
    }

    class BankAccount
    {
        public BankAccount()
        {
            _accountID = _countID;
            _countID++;
        }
        public BankAccount(AccountType accountType)
        {
            _accountID = _countID;
            _accountType = accountType;
            _countID++;
        }
        public BankAccount(AccountType accountType, double balance)
        {
            _accountID = _countID;
            _accountType = accountType;
            _balance = balance;             // проверку на неотрицательный баланс не делал - наверно, по-хорошему, нужно,
            _countID++;                     // хотя видел я прецеденты и с отрицательным балансом)))
        }
        public BankAccount(double balance)
        {
            _accountID = _countID;            
            _balance = balance;             // проверку на неотрицательный баланс не делал - наверно, по-хорошему, нужно,
            _countID++;                     // хотя видел я прецеденты и с отрицательным балансом)))
        }
        private int _accountID;
        private double _balance;
        private AccountType _accountType;
        public AccountType AccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                _accountType = value;
            }
        }

        private static int _countID = 1;

        /// <summary>
        /// Свойство получения ID счета
        /// </summary>
        public int AccountID
        {
            get         // set извне не предусмотрен, т.к. ID генерируются уникальными
            {
                return _accountID;
            }
        }
        
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                try
                {
                    if (value >= 0)
                    {
                        _balance = value;
                    }
                    else
                    {
                        throw new Exception("Указана некорректная величина!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Метод снятия со счета
        /// </summary>
        /// <param name="number">Сумма денег</param>
        public void Widthraw(double number)
        {
            try
            {
                if (number <= _balance)
                {
                    _balance -= number;
                    Console.WriteLine($"Со счета снято {number} у.е. Ваш баланс: {_balance} у.е.");
                }
                else
                {
                    throw new Exception($"Недостаточно денег на счете! Ваш баланс: {_balance} у.е.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Метод пополнения счета
        /// </summary>
        /// <param name="number">Сумма денег</param>
        public void PutToDeposit(double number)
        {
            _balance += number;
            Console.WriteLine($"Поступление {number} у.е. Ваш баланс: {_balance} у.е.");
        }


        // Урок №3
        public void AddMoneyFromAnotherAcc(BankAccount accFrom, int number)
        {
            if (accFrom.Balance >= number)
            {
                accFrom.Widthraw(number);
                _balance += number;
            }
            else 
            {
                throw new Exception("Недостаточно денег на счете. В операции отказано!");                
            }                        
        }

    }
}
