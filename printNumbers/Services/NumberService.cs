using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printNumbers.Services
{
    public class NumberService : INumberService
    {
        private readonly IMultipleService multipleService;

        public NumberService(IMultipleService _multipleService)
        {
            multipleService = _multipleService;
        }

        public string Iterate()
        {
            int nI = 1;
            int nF = 250;
            string ret = "";

            while (nI <= nF)
            {
                if (multipleService.IsMultipleOf(3, nI) && multipleService.IsMultipleOf(5, nI))
                {
                    ret += "ThreeFive" + Environment.NewLine;
                }
                else if (!multipleService.IsMultipleOf(5, nI) && multipleService.IsMultipleOf(3, nI))
                {
                    ret += "Three" + Environment.NewLine;
                }
                else if (!multipleService.IsMultipleOf(3, nI) && multipleService.IsMultipleOf(5, nI))
                {
                    ret += "Five" + Environment.NewLine;
                }
                else
                {
                    ret += nI.ToString() + Environment.NewLine;
                }

                nI++;
            }

            return ret;
        }

    }
}
