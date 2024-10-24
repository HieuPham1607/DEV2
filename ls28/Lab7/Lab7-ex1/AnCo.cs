using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnCo
{
    public class DongVat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public DongVat(int id, string name, double weight)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }
    }

    public class Bo : DongVat
    {
        public Bo(int id, string name, double weight) : base(id, name, weight) { }
    }

    public class Trau : DongVat
    {
        public Trau(int id, string name, double weight) : base(id, name, weight) { }
    }

    public class De : DongVat
    {
        public De(int id, string name, double weight) : base(id, name, weight) { }
    }
}
