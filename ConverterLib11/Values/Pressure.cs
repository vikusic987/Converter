using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib11.Values
{
    internal class Pressure : IValue
    {
        private string _name = "Давление";

        private Dictionary<string, double> _coefDict = new Dictionary<string, double>()
        {
            { "Бар",        1 },
            { "Гигапаскаль",    10000 },
            { "Килопаскаль",    0.01},
            { "Паскаль", 0.00001 }
        };

        public Dictionary<string, double> GetCoefDict()
        {
            return _coefDict;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
