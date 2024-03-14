using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
    [assembly: InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]

namespace Problem_plecakowy
{
    internal class Item
    {
        public int Number { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }
    }
}
