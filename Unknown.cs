using System;

namespace TypesOfClients
{
    public class Unknown
    {
        private string name;
        private string date;
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
    }
}
