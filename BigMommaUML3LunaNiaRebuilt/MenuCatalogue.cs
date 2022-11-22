using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMommaUML3LunaNiaRebuilt
{
    public class MenuCatalogue : IMenuCatalogue
    {
        public int Count { get { return _items.Count; } }

        private Dictionary<int, IMenuItem> _items;

        public MenuCatalogue()
        {
            _items = new Dictionary<int, IMenuItem>();
        }

        public void Add(IMenuItem aMenuItem)
        {
            if (!_items.ContainsKey(aMenuItem.Number))
                _items.Add(aMenuItem.Number, aMenuItem);
            else
                throw new MenuItemNumberExist("Item could not be added. An item with that number already exists.");
        }
        public IMenuItem Search(int number)
        {
            if (_items.ContainsKey(number))
                return _items[number];
            return null;
        }
        public void Delete(int number)
        {
            if (_items.ContainsKey(number))
                _items.Remove(number);
        }
        public void PrintPizzasMenu()
        {
            foreach (IMenuItem a in _items.Values)
            {
                if (a.Type == MenuType.Pizza)
                    Console.WriteLine(a.PrintInfo());
            }
        }
        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem a in _items.Values)
            {
                if ((a.Type == MenuType.SoftDrink) || (a.Type == MenuType.AlcoholicDrink))
                    Console.WriteLine(a.PrintInfo());
            }
        }
        public void PrintToppingsMenu()
        {
            foreach (IMenuItem a in _items.Values)
            {
                if (a.Type == MenuType.Topping)
                    Console.WriteLine(a.PrintInfo());
            }
        }
        public void Update(int number, IMenuItem theMenuItem)
        {
            if (_items.ContainsKey(number))
                _items[number] = theMenuItem;
        }
        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> veganList = new List<IMenuItem>();
            bool vegan = false;

            foreach (IMenuItem a in _items.Values)
            {
                if ((a.IsVegan) && (a.Type == type))
                {
                    veganList.Add(a);
                    vegan = true;
                }
            }
            if (vegan)
                return veganList;
            else
                return null;
        }
        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> organicList = new List<IMenuItem>();
            bool organic = false;
            foreach (IMenuItem a in _items.Values)
            {
                if ((a.IsOrganic) && (a.Type == type))
                {
                    organicList.Add(a);
                    organic = true;
                }
            }
            if (organic)
                return organicList;
            else
                return null;
        }
        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem mostXpen = null;
            double mostXpenDbl = 0;
            foreach (IMenuItem a in _items.Values)
            {
                if (a.Price > mostXpenDbl)
                {
                    mostXpen = a;
                    mostXpenDbl = a.Price;
                }
            }
            return mostXpen;
        }

    }
}
