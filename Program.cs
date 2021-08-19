using System;

namespace testeMaiorMenorMedia
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = {50,354,47, 0, -10};

            int media = nums[0];

            int maior = nums[0];

            int menor = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                media += nums[i];

                if (nums[i] > maior)
                {
                    maior = nums[i];
                }
                else if (nums[i] < menor)
                {
                    menor = nums[i];
                }
            }

            Console.WriteLine($"maior: {maior} menor: {menor} media: {media/(nums.Length)}");

            Console.ReadLine();
            
        }

    }
}
