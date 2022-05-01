using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printNumbers.Services
{
    public interface IMultipleService
    {
        bool IsMultipleOf(int div, int n1);
    }
}
