namespace Day7
{
    
    internal class Program
    {
        static bool AddOrTimes(int[] factors,)//add two numbers together or times two numbers and keps track of whats been added and whats been timesd
        {

            
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
                int.Parse(bothNumbers[0]);
                if (AddOrTimes(factors,))
                {
                    answer++;
                }
                
               
            }
        }
    }
}
