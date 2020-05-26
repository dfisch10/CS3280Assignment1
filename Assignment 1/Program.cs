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

            //Checks for input to add a user to the frienNames list, if input is null or empty, it breaks loop.
            while (true)
            {
                Console.Write("Please enter a name: ");

                String name = Console.ReadLine();

                if (String.IsNullOrEmpty(name))
                {
                    break;
                }

                friendNames.Add(name);
            }

            // Calls method to display the appropriate format based off of # of users in friendNames list.
            FriendLikes(friendNames);
        }

        /// <summary>
        /// The FriendLikes method checks the count of names added to 'friendNames', and returns the appropriate response dependent upon that count/number (checks for one, two, more than two, and null/empty amounts).
        /// </summary>
        /// <param name="friendNames">A List<String> containing names of friends who "liked" your post. </String></param>
        private static void FriendLikes(List<string> friendNames)
        {
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
            else
            {
                Console.WriteLine();
            }
        }
    }
}
