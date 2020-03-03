using System;
using System.Collections.Generic;
using ToDoList.Models;




namespace Program
{
    public class userlist
    {

        static void Main()
        {
            Console.WriteLine("Would you like to add to your list or View. Type Add to add or View to view");
            string userAddView = Console.ReadLine().ToLower();
            if (userAddView == "view")
            {
                Item.DisplayList();
            }
            else if (userAddView == "add")
            {
                Console.WriteLine("What would you like your new task to be called");
                string UserDescription = Console.ReadLine();
                Item newItem = new Item(UserDescription);
            }

            foreach (Item thisItem in Item._instances)
            {
                Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
            }
            Main();
        }

    }

}
