using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testground.Model.Glass.IsolationModels
{
    public class GetChildren
    {
        public virtual IEnumerable<GetChildren> Children { get; set; } 
    }
}
