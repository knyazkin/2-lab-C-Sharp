using System;

namespace TypesOfClients
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
}
