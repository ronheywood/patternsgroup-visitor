using System;
using System.Collections.Generic;
using CompositeMenu.Aggregates;
using CompositeMenu.Client;
using CompositeMenu.Logging;

namespace CompositeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitress = new Waitress(new CompositeMenuConsole(), new List<IEnumerable<MenuItem>>
            {
                GeneratePancakeHouseMenu(),
                GenerateCafeMenu(),
                GenerateDinerMenu(),
                GenerateDessertMenu()
            });

            waitress.PrintAll();

            Console.ReadKey();
        }

        private static IEnumerable<MenuItem> GeneratePancakeHouseMenu()
        {
            var pancakeHouseMenu = new PancakeHouseMenu("Breakfast", "Pancake House breakfast only menu");
            pancakeHouseMenu.AddMenuItem(
                name: "Regular Pancake Breakfast",
                description: "Pancakes with fried eggs and sausage",
                price: 5.5,
                isVegetarian: false);
            pancakeHouseMenu.AddMenuItem(
                name: "Blueberry Pancakes",
                description: "Pancakes made with fresh blueberries and blueberry syrup",
                price: 6.5,
                isVegetarian: true);
            pancakeHouseMenu.AddMenuItem(
                name: "Waffles",
                description: "Waffles with choice of blueberries or strawberries",
                price: 5.0,
                isVegetarian: true);

            return pancakeHouseMenu;
        }

        private static IEnumerable<MenuItem> GenerateCafeMenu()
        {
            var cafeMenu = new CafeMenu("Cafe", "Cafe only lunch menu");
            cafeMenu.AddMenuItem(
                name: "Veggie Burger and sweet potato Fries",
                description: "Veggie burger on a whole wheat bun, lettuce, tomato, and sweet potato fries ",
                price: 7.99,
                isVegetarian: true);
            cafeMenu.AddMenuItem(
                name: "Soup of the day",
                description: "A cup of the soup of the day, with a side salad",
                price: 4.69,
                isVegetarian: false);
            cafeMenu.AddMenuItem(
                name: "Burrito",
                description: "A large burrito, with whole pinto beans and guacamole",
                price: 5.29,
                isVegetarian: true);

            return cafeMenu;
        }

        private static IEnumerable<MenuItem> GenerateDinerMenu()
        {
            var dinerMenu = new DinerMenu("Diner", "Diner lunch and dinner menu");
            dinerMenu.AddMenuItem(
                name: "Cottage Pie",
                description: "Cottage pie with greens and mashed potatoes",
                price: 11.0,
                isVegetarian: false);
            dinerMenu.AddMenuItem(
                name: "Classic Beef",
                description: "100% 6oz British prime beef patty, house mayo, relish, salad",
                price: 8.5,
                isVegetarian: false);
            dinerMenu.AddMenuItem(
                name: "Fish and Chips",
                description: "Beer battered cod with mushy peas and tartar sauce",
                price: 12.5,
                isVegetarian: false);

            return dinerMenu;
        }

        private static IEnumerable<MenuItem> GenerateDessertMenu()
        {
            var dessertMenu = new DessertMenu("Dessert", "Dessert menu available anytime");
            dessertMenu.AddMenuItem(
                name: "Veggie Burger and sweet potato Fries",
                description: "Veggie burger on a whole wheat bun, lettuce, tomato, and sweet potato fries ",
                price: 7.99,
                isVegetarian: true);
            dessertMenu.AddMenuItem(
                name: "Soup of the day",
                description: "A cup of the soup of the day, with a side salad",
                price: 4.69,
                isVegetarian: false);
            dessertMenu.AddMenuItem(
                name: "Burrito",
                description: "A large burrito, with whole pinto beans and guacamole",
                price: 5.29,
                isVegetarian: true);

            return dessertMenu;
        }
    }
}