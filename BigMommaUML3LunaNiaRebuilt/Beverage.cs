using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BigMommaUML3LunaNiaRebuilt
{
    public class Beverage : MenuItem
    {
        private bool _alcohol;

        public bool Alcohol { get { return _alcohol; } set { _alcohol = value; } }

        public Beverage(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool alcohol) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _alcohol = alcohol;
        }
        public override string PrintInfo()
        {
            return $"Number {Number}, Name {Name}, Description {Description}, Price {Price}, Menu Type {Type}, Is Vegan {IsVegan}, Is Organic {IsOrganic}, Alcoholic {_alcohol}";
        }

    }
}
