using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicClass
{
    class Collection
    {
        public List<int> Except(List<int> a,List<int> b)
        {
            return a.Except(b).ToList();
        }
    }
}
