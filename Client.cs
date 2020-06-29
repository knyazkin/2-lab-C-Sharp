using System;

namespace Clients
{
    public class Client
    {
        public class Contributer
        {
            private string familyName;
            private string date;
            private ushort depositAmount;
            private float depositPercentage;
// сеттеры и геттеры
            public string GetFamilyName()
            {
                return familyName;
            }
            public void SetFamilyName(string s)
            {
                familyName=s;
            }
            public string GetDate()
            {
                return date;
            }
            public void SetDate(string d)
            {
                date=d;
            }
            public ushort GetDepositAmount()
            {
                return depositAmount;
            }
            public void SetDepositAmount(ushort d)
            {
                depositAmount=d;
            }
            public float GetDepositPercentage()
            {
                return depositPercentage;
            }
            public void SetDepositPercentage(float d)
            {
                depositPercentage=d;
            }

        }

        public class Creditor
        {
            private string familyName;
            private string date;
            private ushort loanAmount;
            private float loanPercentage;
            private ushort debt;  
// сеттеры и геттеры
            public string GetFamilyName()
            {
                return familyName;
            }
            public void SetFamilyName(string s)
            {
                familyName=s;
            }
            public string GetDate()
            {
                return date;
            }
            public void SetDate(string d)
            {
                date=d;
            }
            public ushort GetLoanAmount()
            {
                return loanAmount;
            }
            public void SetLoanAmount(ushort d)
            {
                loanAmount=d;
            }
            public float GetLoanPercentage()
            {
                return loanPercentage;
            }
            public void SetLoanPercentage(float d)
            {
                loanPercentage=d;
            }
            public ushort GetDebt()
            {
                return debt;
            }
            public void SetDebt(ushort d)
            {
                debt=d;
            }

        }

        public class Organization
        {
            private string name;
            private string date;
            private ushort accountNumber;
            private int summ;
            // сеттеры и геттеры
            public string GetName()
            {
                return name;
            }
            public void SetName(string s)
            {
                name=s;
            }
            public string GetDate()
            {
                return date;
            }
            public void SetDate(string d)
            {
                date=d;
            }
            public ushort GetAccountNumber()
            {
                return accountNumber;
            }
            public void SetAccountNumber(ushort d)
            {
                accountNumber=d;
            }
            public int GetSumm()
            {
                return summ;
            }
            public void SetSumm(int d)
            {
                summ=d;
            }

        }
        public Contributer contributer = new Contributer();
        public Creditor creditor = new Creditor();
        public Organization organization = new Organization();
        private string type;
        public string getType()
        {
            return type;
        }
        public void setType(string s)
        {
            type=s;
        }
        public void Print()
        {
            switch(getType())
                {
                    case "creditor":
                        Console.WriteLine("Фамилия:"+creditor.GetFamilyName());
                        Console.WriteLine("Дата выдачи кредита:"+creditor.GetDate());
                        Console.WriteLine("Размер кредита:"+creditor.GetLoanAmount());
                        Console.WriteLine("Процент по кредиту:"+creditor.GetLoanPercentage());
                        Console.WriteLine("Остаток долга:"+creditor.GetDebt());
                        Console.WriteLine();
                        break;
                    case "contributer":
                        Console.WriteLine("Фамилия:"+contributer.GetFamilyName());
                        Console.WriteLine("Дата открытия вклада:"+contributer.GetDate());
                        Console.WriteLine("Размер вклада:"+contributer.GetDepositAmount());
                        Console.WriteLine("Процент по вкладу:"+contributer.GetDepositPercentage());
                        Console.WriteLine();
                        break;
                    case "organization":
                        Console.WriteLine("Организация:"+organization.GetName());
                        Console.WriteLine("Дата открытия счёта:"+organization.GetDate());
                        Console.WriteLine("Номер счёта:"+organization.GetAccountNumber());
                        Console.WriteLine("Сумма на счету:"+organization.GetSumm());
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
        }
    }
}
