using System;
using TypesOfClients;

namespace Clients
{
    public class Client
    {
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
                        Console.WriteLine("Процент по кредиту:"+creditor.GetLoanPercentage()+"%");
                        Console.WriteLine("Остаток долга:"+creditor.GetDebt());
                        Console.WriteLine();
                        break;
                    case "contributer":
                        Console.WriteLine("Фамилия:"+contributer.GetFamilyName());
                        Console.WriteLine("Дата открытия вклада:"+contributer.GetDate());
                        Console.WriteLine("Размер вклада:"+contributer.GetDepositAmount());
                        Console.WriteLine("Процент по вкладу:"+contributer.GetDepositPercentage()+"%");
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
