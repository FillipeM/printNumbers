using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printNumbers.Services
{
    public class MultipleService : IMultipleService
    {
        public bool IsMultipleOf(int div, int n1)
        {
            return (n1 % div == 0);

        }
    }
}
