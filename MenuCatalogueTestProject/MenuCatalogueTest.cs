namespace MenuCatalogueTestProject
{
    [TestClass]
    public class MenuCatalogueTest
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            IMenuCatalogue m1 = new MenuCatalogue();
            Pizza p1 = new Pizza(1, "a", "a", 23, 0, true, true, true);
            Pizza p2 = new Pizza(2, "a", "a", 23, 0, true, true, true);

            //Act
            int countBefore = m1.Count;
            m1.Add(p1);
            m1.Add(p2);
            int countAfter = m1.Count;


            //Assert
            Assert.AreEqual(countBefore + 2, countAfter);
        }
    }
}