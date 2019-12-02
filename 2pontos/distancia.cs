using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2pontos
{
    class distancia
    {
        private double _x1, _x2, _y1, _y2;


        public string X1 { set => _x1 = Convert.ToDouble(value); }
        public string X2 { set => _x2 = Convert.ToDouble(value); }
        public string Y1 { set => _y1 = Convert.ToDouble(value); }
        public string Y2 { set => _y2 = Convert.ToDouble(value); }


        public string Distancia => (Math.Sqrt((_x1 - _x2) * (_x1 - _x2) + (_y1 - _y2) * (_y1 - _y2))).ToString();
    }
}
