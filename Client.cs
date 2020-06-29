using System;
using TypesOfClients;

namespace Clients
{
    public class Client
    {
        public Contributer contributer = new Contributer();
        public Creditor creditor = new Creditor();
        public Organization organization = new Organization();
        public Unknown unknown = new Unknown();
        private string name;
        public string getName()
        {
            return name;
        }
        public void setName(string _name)
        {
            name=_name;
        }
        private string date;
        public string getDate()
        {
            return date;
        }
        public void setDate(string _date)
        {
            date=_date;
        }

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
                    {
                        Console.WriteLine("Фамилия: "+getName());
                        Console.WriteLine("Дата выдачи кредита: "+getDate());
                        Console.WriteLine("Размер кредита: "+creditor.GetLoanAmount());
                        Console.WriteLine("Процент по кредиту: "+creditor.GetLoanPercentage()+"%");
                        Console.WriteLine("Остаток долга: "+creditor.GetDebt());
                        Console.WriteLine();
                        break;
                    }
                    case "contributer":
                    {
                        Console.WriteLine("Фамилия: "+getName());
                        Console.WriteLine("Дата открытия вклада: "+getDate());
                        Console.WriteLine("Размер вклада: "+contributer.GetDepositAmount());
                        Console.WriteLine("Процент по вкладу: "+contributer.GetDepositPercentage()+"%");
                        Console.WriteLine();
                        break;
                    }
                    case "organization":
                    {
                        Console.WriteLine("Организация: "+getName());
                        Console.WriteLine("Дата открытия счёта: "+getDate());
                        Console.WriteLine("Номер счёта: "+organization.GetAccountNumber());
                        Console.WriteLine("Сумма на счету: "+organization.GetSumm());
                        Console.WriteLine();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Неизвестный клиент: "+getName());
                        Console.WriteLine("Дата подписания договора: "+getDate());
                        break;
                    }
                }
        }
    }
}
