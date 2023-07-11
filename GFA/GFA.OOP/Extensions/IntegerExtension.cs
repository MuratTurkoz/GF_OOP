using GFA.OOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Extensions
{
    public static class IntegerExtension
    {
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }
    }
}
