using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Interfaces
{
    public  interface IFileSaver
    {
        public  void Save(string filename, string content);
    }
}
