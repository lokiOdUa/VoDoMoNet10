using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoDoMoNet10
{
    internal class Program
    {
        static int Main(string[] args)
        {
            CollectionsUtils cu = new CollectionsUtils();

            int errorsCount = 0;
            string errorMessage = "*** ERROR!";
            string testName = "Initialize me!";

            testName = "TestGenerateRandomCollection";
//            List<int> coll1 = cu.GenerateRandomCollection(2, 1, 100500);
            List<int> coll1 = cu.GenerateRandomCollection(4, 1, 1);
            if (coll1[0] == coll1[1])
            {
                Console.WriteLine("{0} in {1} ::: The following values should be different: {2} and {3}", errorMessage, testName, coll1[0], + coll1[1]);
                errorsCount++; 
            }
            if (coll1.Count != 2)
            {
                Console.WriteLine("{0} in {1} ::: Array size should be 2, but got: {2}", errorMessage, testName, coll1.Count);
                errorsCount++;
            }

            testName = "TestIsPrime";
            if (cu.IsPrime(2998) == true)
            {
                Console.WriteLine("{0} in {1} ::: Number {2} should be prime", errorMessage, testName, 2998);
                errorsCount++;
            }
            if (cu.IsPrime(2999) == false)
            {
                Console.WriteLine("{0} in {1} ::: Number {2} should NOT be prime", errorMessage, testName, 2999);
                errorsCount++;
            }

            return errorsCount;
        }
    }
}
