using GFA.OOP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.OOP.Models
{
    public class EnemyPlayer : BaseModel<Guid>
    {
        public string Name { get; set; }
        public double Hp { get; set; }
    }
}
