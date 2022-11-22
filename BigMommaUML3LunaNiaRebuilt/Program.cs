// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using BigMommaUML3LunaNiaRebuilt;

try
{
    MenuCatalogue m1 = new MenuCatalogue();

    Pizza p1 = new Pizza(1, "a", "a", 23, 0, true, true, true);
    Pizza p2 = new Pizza(1, "a", "a", 23, 0, true, true, true);
    Pizza p3 = new Pizza(2, "a", "a", 23, 0, false, false, false);

    m1.Add(p1);

    List<IMenuItem> vm1 = m1.FindAllVegan(MenuType.Pizza);

    m1.Add(p2);
}
catch (MenuItemNumberExist mex)
{
    Console.WriteLine("An error has occurred. " + mex);
}