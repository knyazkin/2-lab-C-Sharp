using System;

namespace TypesOfClients
{
    public class Contributer
    {
        private string familyName;
        private string date;
        private int depositAmount;
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
        public int GetDepositAmount()
        {
            return depositAmount;
        }
        public void SetDepositAmount(int d)
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
