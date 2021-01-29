using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Combinations
{
    public class CombinationAlgorithm
    {
        #region Properties
        //Todos los valores
        private List<decimal> Values { get; set; }

        //La suma total del resumen
        private decimal Total { get; set; }

        //Un array de booleanos para hacer la combinación de forma eficiente
        private bool[] Binary { get; set; }

        private int NumMaxGroupsToFind { get; set; }

        private Response Response { get; set; }
        #endregion Properties

        public CombinationAlgorithm(Request request)
        {
            Values = request.Values;
            Total = request.Total;
            NumMaxGroupsToFind = request.NumMaxGroupsToFind;

            Initialize();
        }

        public Response Find()
        {
            for (int i = 1; (i < Values.Count && Response.GroupsFound.Count < NumMaxGroupsToFind); i++)
                CombineAndAnalize(0, i);

            return Response;
        }

        private void Initialize()
        {
            Binary = new bool[Values.Count];

            for (int i = 0; i < Binary.Length; i++)
                Binary[i] = true;

            Response = new Response();
        }

        private decimal GetSum()
        {
            decimal myTotal = 0m;

            for (int i = 0; i < Binary.Length; i++)
                if (Binary[i])
                    myTotal += Values.ElementAt(i);

            return myTotal;
        }

        private void Analize()
        {
            Response.NumAnalysisMade++;

            if (Response.NumAnalysisMade % 150000 == 0)
                Console.WriteLine("Analysis number " + Response.NumAnalysisMade);

            if (GetSum() == Total)
            {
                List<decimal> newGroup = new List<decimal>();
                for (int j = 0; j < Binary.Length; j++)
                {
                    if (!Binary[j])
                        newGroup.Add(Values.ElementAt(j));
                }
                Response.GroupsFound.Add(newGroup);
            }
        }

        private void CombineAndAnalize(int lenght, int grupo)
        {
            if (Response.GroupsFound.Count >= NumMaxGroupsToFind)
                return;

            if(grupo == 1)
                for(int i = lenght; i < Binary.Length; i++)
                {
                    Binary[i] = false;
                    Analize();
                    Binary[i] = true;
                }
            else
            {
                for (int i = lenght + 1; i < Binary.Length; i++)
                {
                    Binary[i - 1] = false;
                    CombineAndAnalize(i, grupo - 1);
                    Binary[i - 1] = true;
                }
                lenght++;
                grupo--;
            }
        }
    }
}
