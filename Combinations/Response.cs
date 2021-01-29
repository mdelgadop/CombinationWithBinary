using System.Collections.Generic;

namespace ConsoleApp1.Combinations
{
    public class Response
    {
        public int NumAnalysisMade { get; set; }

        public List<List<decimal>> GroupsFound { get; set; }

        public Response()
        {
            NumAnalysisMade = 0;
            GroupsFound = new List<List<decimal>>();
        }
    }
}
