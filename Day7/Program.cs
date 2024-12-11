namespace Day7
{
    
    internal class Program
    {
        static bool AddOrTimes(int[] factors, int total, int index, int sum)//add two numbers together or times two numbers and keeps track of whats been added and whats been timesd
        {
            int numberOfOperators = factors.Length - 1;
            index++;
            sum += factors[index];
            if (sum == total&&index!=numberOfOperators)
            {
                return true;
            }
            else if (index==numberOfOperators)
            {
                return false;
            }
            else
            {
                AddOrTimes(factors, total, index, sum);
            }
            return false;
            
        }


        static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");//dotnetperls.com/category
            int answer = 0;//how many are true
            int[] factors;
            foreach (string line in input)
            {
                int total = 0;
                string[] bothNumbers = line.Split(':');
                string[] factorString = bothNumbers[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                factors =(from value in factorString
                                select int.Parse(value)).ToArray();
                total = int.Parse(bothNumbers[0]);
                if (AddOrTimes(factors, total, 0,0))
                {
                    answer++;
                }
                Console.WriteLine(answer);
               
            }
        }
    }
}
