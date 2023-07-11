using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Common
{
    public interface IModifiedByModel
    {
        DateTimeOffset? LastModifiedOn { get; set; }
        string? ModifiedByUserId { get; set; }
    }
}
