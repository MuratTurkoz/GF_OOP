using GFA.OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Services
{
    public  class TextFileSaver : IFileSaver
    {
        public void Save(string filename, string content)
        {
            File.WriteAllText($"C:\\Users\\Murat\\Desktop\\{filename}.txt", content);
        }
    }
}
