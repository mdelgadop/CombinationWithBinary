using System;
using System.Collections.Generic;
using ConsoleApp1.Combinations;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request()
            {
                Values = GetValues(),
                Total = 88669.78m,
                NumMaxGroupsToFind = 3
            };

            CombinationAlgorithm ri = new CombinationAlgorithm(request);
            Response response = ri.Find();

            Console.WriteLine(string.Format("Found {0} groups in {1} analysis", response.GroupsFound.Count, response.NumAnalysisMade));
            foreach(List<decimal> group in response.GroupsFound)
            {
                Console.WriteLine("Group of discarded:");
                foreach (decimal num in group)
                {
                    Console.WriteLine("\t" + num);
                }
                Console.WriteLine("");
            }

            Console.Read();
        }


        private static List<decimal> GetValues()
        {
            List<decimal> _Values = new List<decimal>();

            #region Values
            _Values.Add(1.81m);
            _Values.Add(6.06m);
            _Values.Add(70.06m);
            _Values.Add(78.05m);
            _Values.Add(97.01m);
            _Values.Add(123.13m);
            _Values.Add(255.09m);
            _Values.Add(372.66m);
            _Values.Add(524.93m);
            _Values.Add(532.1m);
            _Values.Add(549.66m);
            _Values.Add(592.54m);
            _Values.Add(601.61m);
            _Values.Add(640.28m);
            _Values.Add(640.64m);
            _Values.Add(645.85m);
            _Values.Add(691.17m);
            _Values.Add(706.04m);
            _Values.Add(801.02m);
            _Values.Add(811.08m);
            _Values.Add(811.16m);
            _Values.Add(862.82m);
            _Values.Add(881.64m);
            _Values.Add(887.31m);
            _Values.Add(953.1m);
            _Values.Add(955.17m);
            _Values.Add(1046.47m);
            _Values.Add(1137.93m);
            _Values.Add(1179.7m);
            _Values.Add(1222.4m);
            _Values.Add(1226.69m);
            _Values.Add(1279.69m);
            _Values.Add(1286.42m);
            _Values.Add(1366.09m);
            _Values.Add(1380.04m);
            _Values.Add(1399.58m);
            _Values.Add(1417.64m);
            _Values.Add(1446.35m);
            _Values.Add(1478.09m);
            _Values.Add(1484.17m);
            _Values.Add(1488.41m);
            _Values.Add(1493.71m);
            _Values.Add(1498.01m);
            _Values.Add(1498.98m);
            _Values.Add(1516.29m);
            _Values.Add(1576.71m);
            _Values.Add(1588.21m);
            _Values.Add(1654.21m);
            _Values.Add(1658.44m);
            _Values.Add(1674.28m);
            _Values.Add(1714.51m);
            _Values.Add(1807.24m);
            _Values.Add(1917.17m);
            _Values.Add(2015.11m);
            _Values.Add(2028.33m);
            _Values.Add(2091.42m);
            _Values.Add(2176.21m);
            _Values.Add(2351.36m);
            _Values.Add(2495.27m);
            _Values.Add(2717.36m);
            _Values.Add(3286.93m);
            _Values.Add(3505.04m);
            _Values.Add(4610.85m);
            _Values.Add(10110.4m);
            #endregion

            return _Values;
        }
    }
}
