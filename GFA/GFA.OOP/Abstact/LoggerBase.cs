using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Abstact
{
    internal abstract class LoggerBase
    {
        public string Name { get; set; }
        public virtual void Log(string message) => Console.WriteLine($"Logger:{Name},message");
        protected LoggerBase(string name)
        {
            Name = name;
        }
        protected LoggerBase()
        {
           
        }
        public void AliBaba()
        {

        }
    }
}
