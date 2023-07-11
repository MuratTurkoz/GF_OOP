using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Common
{
    public interface IModel<Tkey> where Tkey : class
    {
        Tkey Id { get; set; }

    }
}
