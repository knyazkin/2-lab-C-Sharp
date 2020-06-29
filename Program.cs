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
        /*
        static void Filter (string field, string value, int N, Client[] client)
        {
            switch (field)
            {
                case "name":
                {
                    for (int i=0;i<N;i++)
                    {
                        if((client[i].contributer.GetFamilyName()==value)||(client[i].creditor.GetFamilyName()==value)||
                        (client[i].organization.GetName()==value)||())
                        {
                            client[i].Print();
                        } 
                    }
                    break;
                }
                case "date":
                {
                    break;
                }
                case "percent":
                {
                    break;
                }
                case "summ":
                {
                    break;
                }
                case "debt":
                {
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
        */
        static void Main(string[] args)
        {
// Считываем значения
            string[] str=File.ReadAllLines("input.txt");
            int N = Int32.Parse(str[0]);
            for(int i=0;i<N;i++)
            {
                str[i]=str[i+1];
            }
            str[N]="";

            Client[] client = new Client[N];
// заполняем массив, проверяя корректность данных
            for (int i=0;i<N;i++)
            {
                client[i]=new Client();
                string[] words = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                client[i].setName(words[1]);
                string[] checkDate = words[2].Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            if (((int.Parse(checkDate[0])<32) && (int.Parse(checkDate[0])>0))&&((short.Parse(checkDate[1])<13) && 
                         (short.Parse(checkDate[1])>0))&&(((short.Parse(checkDate[2])<2021) && (short.Parse(checkDate[2])>1950))))
                          {
                                client[i].setDate(words[2]);
                            }
                            else
                            {
                                client[i].setDate("Некорректная дата");
                            }
                        }
                        catch (FormatException)
                        {
                            client[i].setDate("Некорректная дата");
                        }
                switch(words[0])
                {
                    case "Кредитор":
                    {
                        client[i].setType("creditor");
                                                
                        client[i].creditor.SetLoanAmount(int.Parse(words[3]));
                        client[i].creditor.SetLoanPercentage(float.Parse(words[4]));
                        client[i].creditor.SetDebt(ushort.Parse(words[5]));
                        break;
                    }
                    case "Вкладчик":
                    {
                        client[i].setType("contributer");
                        
                        client[i].contributer.SetDepositAmount(int.Parse(words[3]));
                        client[i].contributer.SetDepositPercentage(float.Parse(words[4]));
                        break;
                    }
                    case "Организация":
                    {
                        client[i].setType("organization");
                        
                        client[i].organization.SetAccountNumber(ushort.Parse(words[3]));
                        client[i].organization.SetSumm(int.Parse(words[4]));
                        break;
                    }
                    default:
                    {
                        client[i].setType("unknowm");
                        break;
                    }

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
