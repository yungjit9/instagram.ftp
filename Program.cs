﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            string response = "";
            List<User> userList = new List<User>();
            List<Comment> commentList = new List<Comment>();

            while (response != "8")
            {
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Print the List of Users");
                Console.WriteLine("4. Print the List of Comments");
                Console.WriteLine("5. Look for a User");
                Console.WriteLine("6. Look for a Comment");
                Console.WriteLine("7. Create a Data File");
                Console.WriteLine("8. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");
                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User newUser1 = new User();
                        newUser1.Email = "myemail@hotmail.com";
                        newUser1.Password = "password";
                        newUser1.UserId = 1;
                        newUser1.UserName = "random1";
                        userList.Add(newUser1);

                        User newUser2 = new User();
                        newUser2.Email = "myemail@hotmail.com";
                        newUser2.Password = "password";
                        newUser2.UserId = 2;
                        newUser2.UserName = "random2";
                        userList.Add(newUser2);

                        User newUser3 = new User();
                        newUser3.Email = "myemail@hotmail.com";
                        newUser3.Password = "password";
                        newUser3.UserId = 3;
                        newUser3.UserName = "random3";
                        userList.Add(newUser3);

                        User newUser4 = new User();
                        newUser4.Email = "myemail@hotmail.com";
                        newUser4.Password = "password";
                        newUser4.UserId = 4;
                        newUser4.UserName = "random4";
                        userList.Add(newUser4);

                        User newUser5 = new User();
                        newUser5.Email = "myemail@hotmail.com";
                        newUser5.Password = "password";
                        newUser5.UserId = 5;
                        newUser5.UserName = "random5";
                        userList.Add(newUser5);

                        User newUser6 = new User();
                        newUser6.Email = "myemail@hotmail.com";
                        newUser6.Password = "password";
                        newUser6.UserId = 6;
                        newUser6.UserName = "random6";
                        userList.Add(newUser6);

                        User newUser7 = new User();
                        newUser7.Email = "myemail@hotmail.com";
                        newUser7.Password = "password";
                        newUser7.UserId = 7;
                        newUser7.UserName = "random7";
                        userList.Add(newUser7);

                        User newUser8 = new User();
                        newUser8.Email = "myemail@hotmail.com";
                        newUser8.Password = "password";
                        newUser8.UserId = 8;
                        newUser8.UserName = "random8";
                        userList.Add(newUser8);

                        Console.WriteLine("You have created a user");
                        break;
                    case "2":
                        Comment myComment = new Comment();
                        myComment.CommentId = 1;
                        myComment.TheComment = "Hello";

                        commentList.Add(myComment);

                        Console.WriteLine("You have created a comment ");
                        break;
                    case "3":
                        foreach (var insideUser in userList)
                        {
                            Console.WriteLine("The user email is: " + insideUser.Email);
                            Console.WriteLine("The user password is: " + insideUser.Password);
                            Console.WriteLine("The user id is " + insideUser.UserId);
                            Console.WriteLine("The user name is: " + insideUser.UserName);
                        }
                        break;
                    case "4":
                        Console.WriteLine("These is the list of comments created:");

                        foreach (var insideComment in commentList)
                        {
                            Console.WriteLine("The comment id is: " + insideComment.CommentId);
                            Console.WriteLine("The actual comment is: " + insideComment.TheComment);
                        }
                        break;
                    case "5":
                        userList = (List<User>)userList.Where(user => user.UserName == "Random").ToList();

                        if (userList.Count > 0)
                        {
                            Console.WriteLine("Users found and they have the following properties: ");
                            string format = "my user has these properties: " +
                                            "Email {0}, UserId {1}, Password{2}," +
                                            "UserName: {3}";

                            foreach (var user in userList)
                            {
                                Console.WriteLine(format, user.Email, user.UserId,
                                        user.Password, user.UserName);
                            }
                        }
                        break;
                    case "6":
                        commentList.Where(comment => comment.myComment == "1").ToList();

                        if (commentList.Count > 1)
                        {
                            Console.WriteLine("Comments found");
                        }
                        break;
                    case "7":
                        {
                            string path = "file.txt";

                            FileStream newStream =
                                new FileStream(path, FileMode.Create,
                                               FileAccess.Write);

                            bool result = newStream.CanRead;
                            Console.WriteLine(result);
                        }
                        break;


                }
            }
        }
    }

    internal class Comment
    {
        internal string myComment;

        public int CommentId { get; internal set; }
        public string TheComment { get; internal set; }
    }

    internal class User
    {
        public string Password { get; internal set; }
        public string Email { get; internal set; }
        public int UserId { get; internal set; }
        public string UserName { get; internal set; }
    }
}