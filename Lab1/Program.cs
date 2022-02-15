using System;

namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int firstInput = Convert.ToInt32(Console.ReadLine());
            int secondInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addirion: {secondInput} + {firstInput} = {secondInput + firstInput}");
            Console.WriteLine($"Substarction: {secondInput} - {firstInput} = {secondInput - firstInput}");
            Console.WriteLine($"Multiplication: {secondInput} * {firstInput} = {secondInput * firstInput}");
            Console.WriteLine($"Division: {secondInput} / {firstInput} = {secondInput / firstInput}");
            Console.WriteLine($"Remainder: {secondInput} % {firstInput} = {secondInput % firstInput}");

            int[] array = new int[firstInput];
            Random rand = new Random();
            for (int i = 0; i < firstInput; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine($"Element of array {i + 1} is {array[i]}");
            }
        }
    }
}
