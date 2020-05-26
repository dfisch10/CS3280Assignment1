using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_1
{
    class Assignment_1
    {
     
        /// <summary>
        ///  This is my main method
        /// </summary>
        /// <param name="args">
        /// </param>
        static void Main(string[] args)
        {
            // List to store entered in names via user input
            var friendNames = new List<String>();

            bool addAnother = true;

            //Checks for input to add a user to the frienNames list, if input is null or empty, it breaks loop.
            while(addAnother == true)
            {
                Console.WriteLine("Please enter a name: ");
                String name = Console.ReadLine();

                if (String.IsNullOrEmpty(name)) { break; }
                
                friendNames.Add(name);
            }

            // Logic to display the appropriate format based off of # of users in friendNames list.
            if (friendNames.Count == 1)
            {
                Console.WriteLine(friendNames[0] + " likes your post");
            }
            else if (friendNames.Count == 2)
            {
                Console.WriteLine(friendNames[0] + " and " + friendNames[1] + " like your post.");
            }
            else if (friendNames.Count > 2)
            {
                Console.WriteLine(friendNames[0] + ", " + friendNames[1] + " and " + (friendNames.Count - 2) + " other(s) liked your post");
            }
            else { }
        }
    }
}
