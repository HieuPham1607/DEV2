using AnCo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnThit
{
    public class CaSau : DongVat
    {
        public CaSau(int id, string name, double weight) : base(id, name, weight) { }
    }

    public class Ho : DongVat
    {
        public Ho(int id, string name, double weight) : base(id, name, weight) { }
    }

    public class SuTu : DongVat
    {
        public SuTu(int id, string name, double weight) : base(id, name, weight) { }
    }
}
