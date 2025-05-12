using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMatrix
{
   public class Matrix
    {
        public int Rows { get; }
        public int Columns { get; }

        private readonly double[,] data;
    }
}
