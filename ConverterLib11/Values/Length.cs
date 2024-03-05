using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib11.Values
{
    internal class Length : IValue
    {
        private string _name = "Длина";

        private Dictionary<string, double> _coefDict = new Dictionary<string, double>()
        {
            { "Сантиметры",        1 },
            { "Метры",    100 },
            { "КилоМетры",    100000 }
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
