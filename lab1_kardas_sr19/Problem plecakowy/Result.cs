using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
[assembly: InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]

namespace Problem_plecakowy
{
    internal class Result
    {
        public int TotalValue { get; set; }
        public int TotalWeight { get; set; }
        public List<int> Numbers { get; set; }

        public override string ToString()
        {
            return $"Items: {string.Join(", ", Numbers)}" +Environment.NewLine+$"Total Value: {TotalValue}" + Environment.NewLine+$"Total Weight: {TotalWeight}";
        }
    }
}
