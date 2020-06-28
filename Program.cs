using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using listik;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
// считываем значения и инициализируем массив
            string[] str=File.ReadAllLines("input.txt");

            list[] arr = new list[str.Length];
            
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
        }
    }
}
