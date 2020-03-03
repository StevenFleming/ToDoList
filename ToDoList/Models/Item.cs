using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; set; }
        public static List<Item> _instances = new List<Item> { };

        public static List<Item> GetAll()
        {
            return _instances;
        }
        public Item(string description)
        {
            Description = description;
            _instances.Add(this);
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static void DisplayList()
        {
            foreach (Item thisItem in Item._instances)
            {
                Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
            }
        }
    }

}