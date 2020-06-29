using System;

namespace TypesOfClients
{
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
}
