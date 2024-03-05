using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib11.Values
{
    internal class Speed : IValue
    {
        private string _name = "Скорость";

        private Dictionary<string, double> _coefDict = new Dictionary<string, double>()
        {
            { "м/с",        1 },
            { "км/мин",    16.667 },
            { "км/ч",    3.6 },
            { "миля/ч",    2.237 }
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
