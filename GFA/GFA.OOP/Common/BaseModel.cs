using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Common
{
    public class BaseModel<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreateOn { get; set; }
        public DateTimeOffset? LastModifiedOn { get; set; }
        public virtual void aaa() { }
    }
}
