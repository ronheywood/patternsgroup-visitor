# Breaking News: Objectville Diner and Objectville Pancake House Merge

That’s great news! Now we can get those delicious pancake breakfasts at the Pancake House and those yummy lunches at the Diner all in one place. But, there seems to be a slight problem...

They want to use Pancake House menu as the breakfast menu and the Diner's menu as the lunch menu. Menu items implementation has been agreed on but there is no agreement on how to implement their menus.

We want to implement a client that uses the two menus. 

Imagine you have been hired by the new company formed by the merger of the Diner and the Pancake House to create a C#-enabled waitress. 

The spec for the C#-enabled waitress specifies that she can print a custom menu for customers on demand, and even tell you if a menu item is vegetarian without having to ask the cook — now that’s an innovation!

# Requirements

C#-enabled Waitress: code-name "Alice"

PrintMenu() - prints every item on the menu

PrintBreakfastMenu() - prints just breakfast items

PrintLunchMenu() - prints just lunch items

PrintVegetarianMenu() - prints all vegetarian menu items

IsItemVegetarian(name) - given the name of an item, returns true if the item is vegetarian, otherwise returns false