using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoDoMoNet10
{
    internal class CollectionsUtils
    {
        public List<int> GenerateRandomCollection(int N, int min, int max)
        {
            Random random = new Random();
            List<int> collection = new List<int>();

            for (int i = 0; i < N; i++)
            {
                collection.Add(random.Next(min, max + 1));
            }

            return collection;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number <= 3)
            {
                return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void PrintCollection(List<int> collection)
        {
            foreach (int number in collection)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
