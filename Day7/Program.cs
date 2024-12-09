namespace Day7
{
    
    internal class Program
    {
        static void AddOrMinus(ref string stringNumber1,ref string stringNumber2)
        {
            int number1, number2;
            number1 = int.Parse(stringNumber1);
            number2 = int.Parse(stringNumber2);
            if (number1)
            {

            }

        }
        static void Main()
        {
            string[] input = File.ReadAllLines("input.txt");//dotnetperls.com/category
            int total = 0;

            foreach (string line in input)
            {
                string[] bothNumbers = line.Split(':');
                string[] factors = bothNumbers[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < factors.Length; i++)
                {
                    AddOrMinus(ref factors[i] , ref factors[i+1]);

                }
            }
        }
    }
}