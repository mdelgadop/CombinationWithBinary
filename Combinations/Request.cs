using System.Collections.Generic;

namespace ConsoleApp1.Combinations
{
    public class Request
    {
        public List<decimal> Values { get; set; }

        public decimal Total { get; set; }

        public int NumMaxGroupsToFind { get; set; }
    }
}
