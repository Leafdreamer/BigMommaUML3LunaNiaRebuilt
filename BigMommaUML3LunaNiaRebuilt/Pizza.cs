using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMommaUML3LunaNiaRebuilt
{
    public class Pizza : MenuItem
    {
        private bool _deepPan;

        public bool DeepPan { get { return _deepPan; } set { _deepPan = value; } }

        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _deepPan = deepPan;
        }
        public override string PrintInfo()
        {
            return $"Number {Number}, Name {Name}, Description {Description}, Price {Price}, Menu Type {Type}, Is Vegan {IsVegan}, Is Organic {IsOrganic}, DeepPan {_deepPan}";
        }

    }
}
