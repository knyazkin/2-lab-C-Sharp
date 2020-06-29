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
        static void Insert(int N, Client[] client)
        {
            Console.WriteLine("Вывести всех клиентов банка? [Да/Нет]");
            string ans=Console.ReadLine();
            string field;
            string value;
            switch (ans)
            {
                case "да":
                {
                    Print(N,client);
                    break;
                }
                case "д":
                {
                    Print(N,client);
                    break;
                }
                case "yes":
                {
                    Print(N,client);
                    break;
                }
                case "y":
                {
                    Print(N,client);
                    break;
                }
                case "n":
                {
                    Console.WriteLine("Введите поле, по которому хотите отфильтровать всех клиентов банка:");
                    field=Console.ReadLine();
                    Console.WriteLine("Введите искомое значение данного поля:");
                    value=Console.ReadLine();
                    Filter(field,value,N,client);
                    break;
                }
                case "no":
                {
                    Console.WriteLine("Введите поле, по которому хотите отфильтровать всех клиентов банка:");
                    field=Console.ReadLine();
                    Console.WriteLine("Введите искомое значение данного поля:");
                    value=Console.ReadLine();
                    Filter(field,value,N,client);
                    break;
                }
                case "нет":
                {
                    Console.WriteLine("Введите поле, по которому хотите отфильтровать всех клиентов банка:");
                    field=Console.ReadLine();
                    Console.WriteLine("Введите искомое значение данного поля:");
                    value=Console.ReadLine();
                    Filter(field,value,N,client);
                    break;
                }
                case "н":
                {
                    Console.WriteLine("Введите поле, по которому хотите отфильтровать всех клиентов банка:");
                    field=Console.ReadLine();
                    Console.WriteLine("Введите искомое значение данного поля:");
                    value=Console.ReadLine();
                    Filter(field,value,N,client);
                    break;
                }
                default:
                {
                    Console.WriteLine("Только да или нет");
                    Insert(N,client);
                    break;
                }
            }
        }
        static void Repeat(int N, Client[] client)
        {
            Console.WriteLine("Продолжить работу?[да/нет]");
            string ans=Console.ReadLine();
            switch (ans)
            {
                case "да":
                {
                    Insert(N,client);
                    break;
                }
                case "д":
                {
                    Insert(N,client);
                    break;
                }
                case "yes":
                {
                    Insert(N,client);
                    break;
                }
                case "y":
                {
                    Insert(N,client);
                    break;
                }
                case "n":
                {
                    break;
                }
                case "no":
                {
                    break;
                }
                case "нет":
                {
                    break;
                }
                case "н":
                {
                    break;
                }
                default:
                {
                    Console.WriteLine("Только да или нет");
                    Repeat(N,client);
                    break;
                }
            }
        }
        static void Print(int N, Client[] client)
        {
            for(int i=0;i<N;i++)
            {
                client[i].Print();
            }
            Repeat(N,client);
        }
        static void Filter (string field, string value, int N, Client[] client)
        {
            switch (field)
            {
                case "name":
                {
                    for (int i=0;i<N;i++)
                    {
                        if(client[i].getName()==value)
                        {
                            client[i].Print();
                        } 
                    }
                    break;
                }
                case "date":
                {
                    for (int i=0;i<N;i++)
                    {
                        if(client[i].getDate()==value)
                        {
                            client[i].Print();
                        } 
                    }
                    break;
                }
                default:
                {
                    break;
                }
            }
            Repeat(N,client);
        }
        
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
                client[i].setDate(words[2]);                
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
                        break;
                    }

                }
            }

// Выводим массив в консоль
            Insert(N,client);
        }
    }
}
