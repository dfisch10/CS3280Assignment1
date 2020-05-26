# CS3280Assignment1

Assignment #1 for CS-3280 required us to consider how posts on Facebook look, and have us write a console application that mimics how the UI on Facebook would display when friends like your post. The output for the application was created using the following rules:

- If no one likes your post, it doesn’t display anything.
- If only one person likes your post, it displays [Friend’s Name] likes your post
- If two people like your post, it displays [Friend 1] and [Friend 2] like your post
- If more than two people like your post, it displays [Friend 1], [Friend 2] and [# of other people] others like your post

The program I created incorporates the use of a while loop in the main method to add names entered by the user to a list (friendNames), and then calls a separate method (FriendLikes). FriendLikes that takes that list and uses if/else if/else statements to display the appropriate response dependent upon the count of names that are in the list.
