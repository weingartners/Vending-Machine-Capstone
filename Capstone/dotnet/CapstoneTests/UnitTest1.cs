using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;
using System.Collections.Generic;

namespace CapstoneTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SubMenuOption2Tests()
        {

            //Menu menu = new Menu("1", "2", "3");

            //Chip salt = new Chip("Z7", "salt", 3.50m, "Chip", 3);
            //Chip pepper = new Chip("Z7", "pepper", 3.50m, "Chip", 0);

            //Dictionary<string, Item> expected = new Dictionary<string, Item> { { "Z7" , salt} };
            //Dictionary<string, Item> expected1 = new Dictionary<string, Item> { { "Z7" , pepper} };

            //Dictionary<string, Item> result =  menu.MenuOption1(expected);
            //Dictionary<string, Item> result1 = menu.MenuOption1(expected1);

            //CollectionAssert.AreEqual(result, expected);
            //CollectionAssert.AreEqual(result1, expected1);

        }
        [TestMethod]
        public void SubMenuOption1Tests()
        {
            Menu menu = new Menu("1", "2", "3");

            decimal expected = 3.50m;
            decimal expected1 = 69.42m;

            decimal result = menu.SubMenuOption1(expected);
            decimal result1 = menu.SubMenuOption1(expected1);

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected1, result1);
        }
        [TestMethod]
        public void SubMenuOption3Tests()
        {
            Menu menu = new Menu("1", "2", "3");

            decimal expected = 3.50m;
            decimal expected1 = 69.42m;

            decimal result = menu.SubMenuOption3(expected);
            decimal result1 = menu.SubMenuOption3(expected1);

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected1, result1);
        }
        [TestMethod]
        public void DispenseChangeTests()
        {
            VendingMachine vendingMachine = new VendingMachine();

            decimal expected = 0;

            decimal result = vendingMachine.DispenseChange(0);
            decimal result1 = vendingMachine.DispenseChange(6520);
            decimal result2 = vendingMachine.DispenseChange(8765309);

            Assert.AreEqual(result, expected);
            Assert.AreEqual(result1, expected);
            Assert.AreEqual(result2, expected);
        }
    }
}
