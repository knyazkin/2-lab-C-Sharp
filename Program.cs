﻿using System;
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
// считываем значения и инициализируем массив
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
                        client[i].creditor.SetDate(words[2]);
                        client[i].creditor.SetLoanAmount(ushort.Parse(words[3]));
                        client[i].creditor.SetLoanPercentage(float.Parse(words[4]));
                        client[i].creditor.SetDebt(ushort.Parse(words[5]));
                        break;
                    case "Вкладчик":
                        client[i].setType("contributer");
                        client[i].contributer.SetFamilyName(words[1]);
                        client[i].contributer.SetDate(words[2]);
                        client[i].contributer.SetDepositAmount(ushort.Parse(words[3]));
                        client[i].contributer.SetDepositPercentage(float.Parse(words[4]));
                        break;
                    case "Организация":
                        client[i].setType("organization");
                        client[i].organization.SetName(words[1]);
                        client[i].organization.SetDate(words[2]);
                        client[i].organization.SetAccountNumber(ushort.Parse(words[3]));
                        client[i].organization.SetSumm(int.Parse(words[4]));
                        break;
                    default:
                        break;

                }
            }
            for(int i=0;i<N;i++)
            {
                client[i].Print();
            }

            
            /*
            for (int i=0;i<N;i++)
            {
                Console.WriteLine(str[i]);
            }

            

            
            
            for(int i=0; i < arr.Length; i++)
            {
                arr[i]=new list();
                arr[i].setVal(Int32.Parse(str[i]));
            }
// сортировка значений
            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].getVal() > arr[j].getVal())
                    {
                        temp = arr[i].getVal();
                        arr[i].setVal(arr[j].getVal());
                        arr[j].setVal(temp);
                    }
                }
            }

// проверка на дубликаты            
            for (int i=0; i<arr.Length-1; i++)
            {
                if (arr[i].getVal()==arr[i+1].getVal())
                {
                    if(arr[i].getDupl()==false) arr[i].setDupl(true);
                    arr[i+1].setDupl(true);
                }
            }
            
// запись только дубликатов
            var text = new StreamWriter("output.txt");

            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i].getDupl()==false)
                {
                    continue;
                }
                else
                {
                    if (arr[i].getVal()==arr[i+1].getVal())
                    {
                        continue;
                    }
                    else text.Write(arr[i].getVal());
                }
                text.WriteLine();
            }
            text.Close();
            */
        }
    }
}
