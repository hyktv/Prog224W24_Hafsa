namespace Prog224W24_Hafsa
{
    // Hafsa Mohamed
    // Why is it still dark outside, Joe? 
    //final project

    internal class Program
    {
        static void Main(string[] args)
        {
            string inventoryFilePath = "inventory.json";

            Inventory inventory = new Inventory();

            // Load inventory data from JSON file
            inventory.LoadFromJson(inventoryFilePath);

            bool exit = false;
            while (!exit)
            {
                //menu display
                Console.Write("Welcome to the Why is it still dark outside, Joe? App");
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Ring Up Customer");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        inventory.DisplayProducts();
                        break;
                    case "2":
                        AddProductToInventory(inventory);
                        break;
                    case "3":
                        CreateOrder(inventory);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        break;
                }
            }

            // Save inventory data to JSON file before exiting
            inventory.SaveToJson(inventoryFilePath);
        }

        //add product method
        static void AddProductToInventory(Inventory inventory)
        {
            Console.WriteLine("Enter product details:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            double price;
            while (true)
            {
                Console.Write("Price: $");
                if (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
                {
                    Console.WriteLine("Invalid price. Please enter a valid positive number.");
                }
                else
                {
                    break;
                }
            }

            // Create a new merchandise product and add it to the inventory
            Merchandise newProduct = new Merchandise { Name = name, Price = price };
            inventory.AddProduct(newProduct);
            Console.WriteLine("Product added to inventory.");
        }

        //create order method
        static void CreateOrder(Inventory inventory)
        {
            Order order = new Order();
            Console.WriteLine("Select a product to add to the order:");
            inventory.DisplayProducts();

            bool continueAddingProducts = true;
            while (continueAddingProducts)
            {
                Console.Write("Enter product number: ");
                if (int.TryParse(Console.ReadLine(), out int productNumber) && productNumber >= 1 && productNumber <= inventory.Products.Count)
                {
                    Product selectedProduct = inventory.Products[productNumber - 1];
                    order.AddProduct(selectedProduct);
                    Console.WriteLine("Product added to the order.");

                    Console.Write("Do you want to add more products to the order? (yes/no): ");
                    string response = Console.ReadLine().ToLower();
                    if (response != "yes")
                    {
                        continueAddingProducts = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product number. Please enter a valid number.");
                }
            }

            // Calculate total price of the order
            double totalPrice = order.CalculateTotalPrice();

            // Generate receipt
            Receipt receipt = new Receipt { Order = order, TotalPrice = totalPrice };
            Console.WriteLine($"Total price of the order: ${totalPrice}");
            Console.WriteLine("Receipt:");
            Console.WriteLine(receipt);

        }//main


    }//class


}//namespace