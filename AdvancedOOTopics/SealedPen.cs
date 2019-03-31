using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOTopics
{
    public sealed class SealedPen
    {
        public SealedPen(string type)
        {
            Type = type;
        }

        public string Type { get; private set; }
    }
}
