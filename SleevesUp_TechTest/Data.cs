using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SleevesUp_TechTest
{
    /* Nupur  */
    /* Implementation Class for Number functions to achieve desire number output */
    
    public class Data : IDisposable
    {
        private IOrderedEnumerable<int> uniqueNumberList;
        private List<List<int>> finalOutput;

        public Data()
        {
            finalOutput = new List<List<int>>();
        }

        public void Processing()
        {
            try
            {
                uniqueNumberList = NumbersLibrary.GetUniqueNumbersInRange();
                int firstRow = NumbersLibrary.GetMinValueFromList(uniqueNumberList);
                int SecondRow = NumbersLibrary.GetValueFromList(uniqueNumberList, 2, 9);
                int ThirdRow = NumbersLibrary.GetValueFromList(uniqueNumberList, 3, 9);
                int FourthRow = NumbersLibrary.GetValueFromList(uniqueNumberList, 4, 8);
                int FifthRow = NumbersLibrary.ReverseNumber(NumbersLibrary.GetValueFromList(uniqueNumberList, 1, 8)); 

                finalOutput.Add(NumbersLibrary.ConvertNumberToArray(firstRow));
                finalOutput.Add(NumbersLibrary.ConvertNumberToArray(SecondRow));
                finalOutput.Add(NumbersLibrary.ConvertNumberToArray(ThirdRow));
                finalOutput.Add(NumbersLibrary.ConvertNumberToArray(FourthRow));
                finalOutput.Add(NumbersLibrary.ConvertNumberToArray(FifthRow));
            }
            catch
            {
                throw;
            }
        }

        public void Display()
        {
            if (finalOutput != null)
            {
                foreach (var displayRow in finalOutput)
                {
                    Console.WriteLine(string.Join(",", displayRow));
                }
            }
        }

        public void Dispose()
        {
            if (finalOutput != null)
            {
                finalOutput = null;
            }
            if(uniqueNumberList != null)
            {
                uniqueNumberList = null;
            }            
        }
    }
}
