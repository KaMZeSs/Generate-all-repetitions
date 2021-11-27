using System;

namespace Generate_all_repetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            Repetition repetition = new Repetition(new char[] { 'a', 'b', 'c', 'd' });
            
            for (String str = String.Empty; str.Length <= 4; str = new String(repetition.nextStep()))
            {
                Console.WriteLine(str);

            }
        }
    }
}
