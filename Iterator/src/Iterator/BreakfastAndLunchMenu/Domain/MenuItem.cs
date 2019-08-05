namespace BreakfastAndLunchMenu.Domain
{
    public class MenuItem
    {
        public MenuItem(string id, string name, string description, double price, bool isVegetarian)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVegetarian;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public bool IsVegetarian { get; set; }
    }
}