using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Pyramid
    {
        protected Double _edge, _basis;
        public Pyramid(Double basis, Double edge)
        {
            _edge = edge;
            _basis = basis;
        }

        public double Edge
        {
            get { return _edge; }
            set { _edge = value; }
        }
        public double Basis
        {
            get { return _basis; }
            set { _basis = value; }
        }
    }
}

        
