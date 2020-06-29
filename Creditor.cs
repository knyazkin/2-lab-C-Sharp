using System;

namespace TypesOfClients
{
    public class Creditor
    {
        private string familyName;
        private string date;
        private int loanAmount;
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
        public int GetLoanAmount()
        {
            return loanAmount;
        }
        public void SetLoanAmount(int d)
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
}