namespace Day7
{
    
    internal class Program
    {
        static bool AddOrTimes(ulong[] factors, ulong total, int index, ulong sum)
        {
            //add two numbers together or times two numbers and keeps track of whats been added and whats been timesd
            if (index == factors.Length)
            {
                return sum == total;
            }
            if (sum >= total && index != factors.Length)
            {
                return false;
            }

            return AddOrTimes(factors, total, index + 1, sum + factors[index])
                || AddOrTimes(factors, total, index + 1, sum * factors[index]);
        }

        static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");//dotnetperls.com/category
            ulong answer = 0;//how many are true
            ulong[] factors;
            foreach (string line in input)
            {
                ulong total = 0;
                string[] bothNumbers = line.Split(':');
                string[] factorString = bothNumbers[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                factors = (from value in factorString
                                select ulong.Parse(value)).ToArray();
                total = ulong.Parse(bothNumbers[0]);
                if (AddOrTimes(factors, total, 1, factors[0]))
                {
                    answer += total;
                }
            }
            Console.WriteLine(answer);
            //32033638746 too low
            //1297330561377 too low

        }
    }
}
