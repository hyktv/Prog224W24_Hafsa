using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Prog224W24_Hafsa
{
    public class Inventory : IEnumerable<Product>
    {
        //global list
        public List<Product> Products { get; set; } = new List<Product>();

        //methods
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public void SaveToJson(string filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(Products);
                File.WriteAllText(filePath, json);
                Console.WriteLine("Inventory data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving inventory data: {ex.Message}");
            }
        }

        public void LoadFromJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    Products = JsonSerializer.Deserialize<List<Product>>(json);
                    Console.WriteLine("Inventory data loaded successfully.");
                }
                else
                {
                    Console.WriteLine("Inventory data file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading inventory data: {ex.Message}");
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Available Products:");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }
}
