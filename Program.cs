using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Clients;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
// Считываем значения и инициализируем массив
            string[] str=File.ReadAllLines("input.txt");
            int N = Int32.Parse(str[0]);
            for(int i=0;i<N;i++)
            {
                str[i]=str[i+1];
            }
            str[N]="";

            Client[] client = new Client[N];

            for (int i=0;i<N;i++)
            {
                client[i]=new Client();
                string[] words = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch(words[0])
                {
                    case "Кредитор":
                        client[i].setType("creditor");
                        client[i].creditor.SetFamilyName(words[1]);
                        string[] checkDateK = words[2].Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            if (((int.Parse(checkDateK[0])<32) && (int.Parse(checkDateK[0])>0))&&((short.Parse(checkDateK[1])<13) && 
                         (short.Parse(checkDateK[1])>0))&&(((short.Parse(checkDateK[2])<2021) && (short.Parse(checkDateK[2])>1950))))
                          {
                                client[i].creditor.SetDate(words[2]);
                            }
                            else
                            {
                                client[i].creditor.SetDate("Некорректная дата");
                            }
                        }
                        catch (FormatException)
                        {
                            client[i].creditor.SetDate("Некорректная дата");
                        }
                        
                        client[i].creditor.SetLoanAmount(int.Parse(words[3]));
                        client[i].creditor.SetLoanPercentage(float.Parse(words[4]));
                        client[i].creditor.SetDebt(ushort.Parse(words[5]));
                        break;
                    case "Вкладчик":
                        client[i].setType("contributer");
                        client[i].contributer.SetFamilyName(words[1]);
                        string[] checkDateV = words[2].Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            if (((int.Parse(checkDateV[0])<32) && (int.Parse(checkDateV[0])>0))&&((short.Parse(checkDateV[1])<13) && 
                            (short.Parse(checkDateV[1])>0))&&(((short.Parse(checkDateV[2])<2021) && (short.Parse(checkDateV[2])>1950))))
                            {
                                client[i].contributer.SetDate(words[2]);
                            }
                            else
                            {
                                client[i].contributer.SetDate("Некорректная дата");
                            }
                        }
                        catch (FormatException)
                        {
                            client[i].contributer.SetDate("Некорректная дата");
                        }    
                        client[i].contributer.SetDepositAmount(int.Parse(words[3]));
                        client[i].contributer.SetDepositPercentage(float.Parse(words[4]));
                        break;
                    case "Организация":
                        client[i].setType("organization");
                        client[i].organization.SetName(words[1]);
                        string[] checkDateO = words[2].Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            if (((int.Parse(checkDateO[0])<32) && (int.Parse(checkDateO[0])>0))&&((short.Parse(checkDateO[1])<13) && 
                            (short.Parse(checkDateO[1])>0))&&(((short.Parse(checkDateO[2])<2021) && (short.Parse(checkDateO[2])>1950))))
                            {
                                client[i].organization.SetDate(words[2]);
                            }
                            else
                            {
                                client[i].organization.SetDate("Некорректная дата");
                            }
                            }
                        catch (FormatException)
                        {
                            client[i].organization.SetDate("Некорректная дата");
                        }
                        client[i].organization.SetAccountNumber(ushort.Parse(words[3]));
                        client[i].organization.SetSumm(int.Parse(words[4]));
                        break;
                    default:
                        break;

                }
            }

// Выводим массив в консоль
            for(int i=0;i<N;i++)
            {
                client[i].Print();
            }

        }
    }
}
