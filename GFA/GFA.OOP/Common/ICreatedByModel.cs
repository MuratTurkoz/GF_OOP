using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Common
{
    public interface ICreatedByModel
    {
        DateTimeOffset CreatedOn { get; set; }
        public string? CreatedByUserId { get; set; }    
    }
}
