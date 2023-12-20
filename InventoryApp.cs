class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}
class InventoryApp
{
    static List<InventoryItem> inventory = new List<InventoryItem>();
    static void Main()
    {
        bool exitRequested = false;
        while (!exitRequested)
        {
            Console.WriteLine("\nInventory Management System");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Search for Item");
            Console.WriteLine("4. Delete Item");
            Console.WriteLine("5. Total Quantity");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option (1-6): ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddItem();
                    break;
                case "2":
                    ViewInventory();
                    break;
                case "3":
                    SearchItem();
                    break;
                case "4":
                    DeleteItem();
                    break;
                case "5":
                    TotalQuantity();
                    break;
                case "6":
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    static void AddItem()
    {
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();
        Console.Write("Enter quantity: ");
        if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
        {
            InventoryItem newItem = new InventoryItem { Name = itemName, Quantity = quantity };
            inventory.Add(newItem);
            Console.WriteLine($"{quantity} {itemName}(s) added to the inventory.");
        }
        else
        {
            Console.WriteLine("Invalid quantity. Please enter a non-negative number.");
        }
    }
    static void ViewInventory()
    {
        Console.WriteLine("\nCurrent Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Name}: {item.Quantity}");
        }
    }
    static void SearchItem()
    {
        Console.Write("Enter item name to search: ");
        string searchName = Console.ReadLine();
        InventoryItem foundItem = inventory.Find(item => item.Name.ToLower() == searchName.ToLower());
        if (foundItem != null)
        {
            Console.WriteLine($"{foundItem.Name} found in the inventory. Quantity: {foundItem.Quantity}");
        }
        else
        {
            Console.WriteLine($"{searchName} not found in the inventory.");
        }
    }
    static void DeleteItem()
    {
        Console.Write("Enter item name to delete: ");
        string deleteName = Console.ReadLine();
        InventoryItem itemToRemove = inventory.Find(item => item.Name.ToLower() == deleteName.ToLower());
        if (itemToRemove != null)
        {
            inventory.Remove(itemToRemove);
            Console.WriteLine($"{deleteName} deleted from the inventory.");
        }
        else
        {
            Console.WriteLine($"{deleteName} not found in the inventory.");
        }
    }

    static void TotalQuantity()
    {
        int TotalQuantity = 0;
        foreach (var item in inventory)
        {
            TotalQuantity += item.Quantity;
        }
        Console.WriteLine($"Total Quantity in inventory: {TotalQuantity}");
    }
}