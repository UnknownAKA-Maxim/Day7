using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;
namespace Day7_dotnetframework_
{
    internal class Program
    {
        static bool Part2(ulong[] factors, ulong total, int index, ulong sum, string[] factorString,ref int concatinatedIndex)
        {
            
            ulong integersConcatinated;
            ulong[] newArray=new ulong[factors.Length-1];
            int j=1;
            if (index<=factors.Length-1) 
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (index-1 == i)
                    {
                        integersConcatinated = ulong.Parse(factorString[index-1] + "" + factorString[index]);
                        newArray[index-1] = integersConcatinated;
                    }
                    else
                    {
                        newArray[j] = factors[i+1];
                        j++;
                    }
                }
            }
            if (index<factors.Length) 
            {
                return AddOrTimes(newArray, total, 0, 0);
            }
            else
            {

            }
        }
        static bool AddOrTimes(ulong[] factors, ulong total, int index, ulong sum)
        {
            //add two numbers together or times' two numbers and keeps track of whats been added and whats been timesed
            if (index == factors.Length)
            {
                return sum == total;
            }
            if (sum > total && index != factors.Length)
            {
                return false;
            }

            return AddOrTimes(factors, total, index + 1, sum + factors[index])
                || AddOrTimes(factors, total, index + 1, sum * factors[index]);
        }

        static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");//dotnetperls.com/category
            ulong answer = 0;
            ulong[] factors;
            foreach (string line in input)
            {
                ulong total = 0;
                string[] bothNumbers = line.Split(':');
                string FactorVar=bothNumbers[1].Trim();
                string[] factorString = FactorVar.Split(' ');
                factors = (from value in factorString
                            select ulong.Parse(value)).ToArray();//number of operands
                total = ulong.Parse(bothNumbers[0]);
                if (AddOrTimes(factors, total, 1, factors[0]))
                {
                    answer += total;
                }
                else
                {
                    int concatinatedIndex = 0;
                    if (Part2(factors, total, 1, factors[0], factorString,ref concatinatedIndex))
                    {
                        answer += total;
                    }
                }
            }
            Console.WriteLine(answer);
            Console.ReadLine();
            //32033638746 too low
            //1297330561377 too low
            //1298300076754 Right for the first part second part its too low for
        }
    }
    

}
