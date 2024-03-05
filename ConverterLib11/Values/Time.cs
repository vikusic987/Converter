using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLib11
{
    public class Time: IValue
    {
        private string _name = "Время";        

        private Dictionary<string, double> _coefDict = new Dictionary<string, double>()
        {
            { "секунды",        1 },
            { "минуты",         60 },
            { "часы",           60*60 },
            { "миллисекунды",    0.001 }
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